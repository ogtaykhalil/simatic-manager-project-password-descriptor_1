using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_300_400_Password_Finder
{
    internal class PasswordFinder
    {
        public void PrintPassword()
        {
            char[] password = DecodeUserData();
            
            Console.WriteLine(password);
           
        }
        private const int _thirdLevelSecurityPattern = 0xAA;
        char[] DecodeUserData()
        {
            char[] encodedPassword = GatherHexValueToChar();
            char[] decodedPassword = new char[8];

            
            decodedPassword[1] = (char)(encodedPassword[1] ^ _thirdLevelSecurityPattern);
            
            decodedPassword[3] = (char)(encodedPassword[3] ^ decodedPassword[1]);

            for (int i = 4; i < 8; i++)
                decodedPassword[i] = i switch
                                     {
                                         < 2 => (char)(encodedPassword[i] ^ _thirdLevelSecurityPattern),
                                         < 4 => (char)(encodedPassword[i] ^ decodedPassword[i - 2]),
                                         _ => (char)(encodedPassword[i] ^ decodedPassword[i - 2] ^ encodedPassword[i - 4])
                                     };
            return decodedPassword;
        }

        char[] GatherHexValueToChar()
        {
            char[] encodedPassword = new char[8];
            string[] hex = GetUserData();
            try
            {
                for (int i = 0; i < encodedPassword.Length; i++)     
                    encodedPassword[i] = (char)int.Parse(hex[i], NumberStyles.HexNumber); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message +"\n" + "please, enter full encoded data\n");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message + "\n" + "\n");
            }
            return encodedPassword;
        }

        string[] GetUserData()
        {           
            var userData = Console.ReadLine()?.Trim();
           
            return SplitUserDataWithSpaceInPairs(userData).Split();
        }

       string SplitUserDataWithSpaceInPairs(string? data)
        {
            return string.Join(" ", Enumerable.Range(0, data.Length / 2)
                                              .Select(i => data.Substring(i * 2, 2)));
        }

    }
}

