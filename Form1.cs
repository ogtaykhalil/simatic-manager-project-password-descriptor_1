using System.Globalization;

namespace S7_300_400_Password_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DecodePasswordButton_Click(object sender, EventArgs e)
        {
            DisplayDecodedPassword();
        }

        public void DisplayDecodedPassword()
        {
            char[] decodedPassword = DecryptUserPassword;
            DecodedPasswordTextBox.Text = new string(decodedPassword);
        }


        private const int _thirdLevelSecurityPattern = 0xAA;
        Color redColor = Color.Tomato;
        Color greenColor = Color.LightGreen;

        char[] DecryptUserPassword
        {
            get
            {
                char[] encodedPassword = GatherHexValueToChar();
                char[] decodedPassword = new char[8];

                for (int i = 0; i < 8; i++)

                    decodedPassword[i] = i switch
                    {
                        < 2 => (char)(encodedPassword[i] ^ _thirdLevelSecurityPattern),
                        < 4 => (char)(encodedPassword[i] ^ decodedPassword[i - 2]),
                        _ => (char)(encodedPassword[i] ^ decodedPassword[i - 2] ^ encodedPassword[i - 4]),
                    };

                return decodedPassword;
            }
        }

        char[] GatherHexValueToChar()
        {
            char[] encodedPassword = new char[8];
            string[] hex = UserData;
            try
            {
                for (int i = 0; i < encodedPassword.Length; i++)
                    encodedPassword[i] = (char)int.Parse(hex[i], NumberStyles.HexNumber);

                SetTextBoxColors(Color.LightGreen);
            }
            catch (FormatException ex)
            {
                HandleException(ex, "Invalid data input!");
            }
            catch (IndexOutOfRangeException ex)
            {
                HandleException(ex, "Enter complete encoded data!");
            }
            catch (OverflowException ex)
            {
                HandleException(ex, "Data input too big or too small!");
            }

            return encodedPassword;
        }

        void SetTextBoxColors(Color color)
        {
            encodedDataTextBox.BackColor = color;
            DecodedPasswordTextBox.BackColor = color;
        }

        void HandleException(Exception ex, string message)
        {
            MessageBox.Show(ex.Message + "\n" + message);
            SetTextBoxColors(Color.Tomato);
        }

        string[] UserData
        {
            get
            {
                string? userData = encodedDataTextBox.Text.Trim();

                return SplitUserDataWithSpaceInPairs(userData).Split();
            }
        }

        string SplitUserDataWithSpaceInPairs(string data)
        {
            return string.Join(" ", Enumerable.Range(0, data.Length / 2)
                                              .Select(i => data.Substring(i * 2, 2)));
        }

    }
}