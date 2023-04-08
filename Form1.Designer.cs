namespace S7_300_400_Password_Finder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            encodedDataTextBox = new TextBox();
            DecodedPasswordTextBox = new TextBox();
            ncoded = new Label();
            label1 = new Label();
            DecodePasswordButton = new Button();
            SuspendLayout();
            // 
            // encodedDataTextBox
            // 
            encodedDataTextBox.BorderStyle = BorderStyle.None;
            encodedDataTextBox.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            encodedDataTextBox.Location = new Point(19, 31);
            encodedDataTextBox.Multiline = true;
            encodedDataTextBox.Name = "encodedDataTextBox";
            encodedDataTextBox.Size = new Size(163, 36);
            encodedDataTextBox.TabIndex = 0;
            encodedDataTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DecodedPasswordTextBox
            // 
            DecodedPasswordTextBox.BorderStyle = BorderStyle.None;
            DecodedPasswordTextBox.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DecodedPasswordTextBox.Location = new Point(19, 163);
            DecodedPasswordTextBox.Multiline = true;
            DecodedPasswordTextBox.Name = "DecodedPasswordTextBox";
            DecodedPasswordTextBox.Size = new Size(164, 37);
            DecodedPasswordTextBox.TabIndex = 1;
            DecodedPasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ncoded
            // 
            ncoded.AutoSize = true;
            ncoded.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ncoded.Location = new Point(20, 7);
            ncoded.Name = "ncoded";
            ncoded.Size = new Size(163, 21);
            ncoded.TabIndex = 2;
            ncoded.Text = "Encoded User Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 139);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 3;
            label1.Text = "Decoded Password";
            // 
            // DecodePasswordButton
            // 
            DecodePasswordButton.BackColor = SystemColors.ActiveCaption;
            DecodePasswordButton.Location = new Point(19, 91);
            DecodePasswordButton.Name = "DecodePasswordButton";
            DecodePasswordButton.Size = new Size(162, 35);
            DecodePasswordButton.TabIndex = 4;
            DecodePasswordButton.Text = "SHOW PASSWORD";
            DecodePasswordButton.UseVisualStyleBackColor = true;
            DecodePasswordButton.Click += DecodePasswordButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(205, 229);
            Controls.Add(DecodePasswordButton);
            Controls.Add(label1);
            Controls.Add(ncoded);
            Controls.Add(DecodedPasswordTextBox);
            Controls.Add(encodedDataTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox encodedDataTextBox;
        private TextBox DecodedPasswordTextBox;
        private Label ncoded;
        private Label label1;
        private Button DecodePasswordButton;
    }
}