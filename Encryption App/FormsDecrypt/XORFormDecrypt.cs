using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_App.Forms
{
    public partial class XORFormDecrypt : Form
    {
        public XORFormDecrypt()
        {
            InitializeComponent();
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            //  input reader lang   
            string encryptedText = txtInput.Text.Trim(); //input nag reremove ng excess white space sa dulo
            string key = txtKey.Text;

            // Decrypt the encrypted text
            string decryptedText = Decrypt(encryptedText, key);

            // Display decrypted text
            lblResult.Text = "Decrypted Word: " + decryptedText;

            panelAnswer.Visible = true;
        }

        private string Decrypt(string encryptedWord, string key)
        {
            StringBuilder decryptedWord = new StringBuilder(); //combine each string into one, para di nag mag interate each one, builder ng .NET na bahala 

            string[] encryptedLetters = encryptedWord.Split(' ');  // Split nya yung each binary string and lagay nya sa array, dito string pa sya kaya di ma xor

            for (int i = 0; i < encryptedLetters.Length; i++) //iterate to all the letters
            {
                int encryptedAscii = Convert.ToInt32(encryptedLetters[i], 2); //convert yung letter na encrypted na string sa base 2 binary int para ma read ng XOR, base 2 kasi yun yung ascii
                int keyAscii = (int)key[i % key.Length]; // Ensure key is repeated if shorter than word based on the same index

                int decryptedAscii = encryptedAscii ^ keyAscii; //XOR Operation

                char decryptedChar = (char)decryptedAscii; //gawin nyang char yung binary
                decryptedWord.Append(decryptedChar); //pag sasama nya
            }
            return decryptedWord.ToString(); 
        }

        private bool ValidateInputs()
        {
            var isValid = true;

            // Validate nya yung txtInput: must be 8-bit binary sequences separated ng spaces
            string inputPattern = @"^([01]{8})(\s[01]{8})*$";
            if (string.IsNullOrWhiteSpace(txtInput.Text) || !Regex.IsMatch(txtInput.Text.Trim(), inputPattern))
            {
                lblMessageError.Text = "Invalid input format. Must be 8-bit binary sequences separated by spaces.";
                lblMessageError.Visible = true;
                isValid = false;
            }
            else
            {
                lblMessageError.Visible = false;
            }

            // Validate nya yung txtKey: must not contain any digits
            if (string.IsNullOrWhiteSpace(txtKey.Text) || Regex.IsMatch(txtKey.Text, @"\d"))
            {
                lblKeyError.Text = "Key must not contain any digits.";
                lblKeyError.Visible = true;
                isValid = false;
            }
            else
            {
                lblKeyError.Visible = false;
            }

            return isValid;
        }

        private void HideErrors()
        {
            lblMessageError.Visible = false;
            lblKeyError.Visible = false;
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtKey.Clear();
            panelAnswer.Visible = false;
            lblMessageError.Visible = false;
            lblKeyError.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ChoiceForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new MainMenu();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblResult.Text);
            lblNotif.Visible = true;
            await Task.Delay(2000);
            lblNotif.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
