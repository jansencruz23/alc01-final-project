using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_App.Forms
{
    public partial class XORForm : Form
    {
        public XORForm()
        {
            InitializeComponent();
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            //kunin lang
            string text = tbWord.Text;
            string key = tbKey.Text;

            // Encrypt the text
            string encryptedText = Encrypt(text, key);

            // Display encrypted text
            tbEncrypted.Text = "Encrypted Word: " + encryptedText;
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            //kunin lang
            string encryptedText = labelEncrypted.Text.Substring("Encrypted Word: ".Length);
            string key = tbKey.Text;

            // Decrypt the encrypted text
            string decryptedText = Decrypt(encryptedText, key);

            // Display decrypted text
            labelDecrypted.Text = "Decrypted Word: " + decryptedText;
        }

        private string Encrypt(string word, string key)
        {
            StringBuilder encryptedWord = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                int wordAscii = (int)word[i];

                int keyAscii = (int)key[i % key.Length]; // Ensure key is repeated if shorter than word

                int xorResult = wordAscii ^ keyAscii;
                string binaryResult = Convert.ToString(xorResult, 2).PadLeft(8, '0'); // ASCII is 8 bits
                encryptedWord.Append(binaryResult + " ");
            }
            return encryptedWord.ToString().Trim();
        }

        private string Decrypt(string encryptedWord, string key)
        {
            StringBuilder decryptedWord = new StringBuilder(); //string
            string[] encryptedLetters = encryptedWord.Split(' '); //spacing lang
            for (int i = 0; i < encryptedLetters.Length; i++) //loop sa lahat ng letters
            {
                int encryptedAscii = Convert.ToInt32(encryptedLetters[i], 2); //covert muna sa ascuu
                int keyAscii = (int)key[i % key.Length]; // Ensure key is repeated if shorter than word
                int decryptedAscii = encryptedAscii ^ keyAscii;
                char decryptedChar = (char)decryptedAscii;
                decryptedWord.Append(decryptedChar);
            }
            return decryptedWord.ToString();
        }
    }
}