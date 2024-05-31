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
            // Get the text and key from the text boxes
            string text = tbWord.Text;
            string key = tbKey.Text;

            // Check if the key needs to be extended
            if (key.Length < text.Length)
            {
                // Extend the key by repeating it
                int repeatCount = text.Length / key.Length + 1;
                key = key.PadRight(repeatCount * key.Length, ' ');
            }

            // Convert text and key to binary strings
            string textBinary = StringToBinary(text);
            string keyBinary = StringToBinary(key);

            // Perform XOR operation on binary strings
            string encryptedBinary = PerformXOR(textBinary, keyBinary);

            // Display encrypted binary string
            labelEncrypted.Text = "Encrypted Word: " + encryptedBinary;
        }

        private string StringToBinary(string input)
        {
            StringBuilder binary = new StringBuilder();
            foreach (char c in input)
            {
                binary.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return binary.ToString();
        }

        private string PerformXOR(string textBinary, string keyBinary)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < textBinary.Length; i++)
            {
                // Perform XOR operation on each bit
                char xorResult = textBinary[i] == keyBinary[i] ? '0' : '1';
                result.Append(xorResult);
            }
            return result.ToString();
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            // Get the encrypted binary string
            string encryptedBinary = labelEncrypted.Text.Substring("Encrypted Word: ".Length);

            // Convert the key to binary
            string key = tbKey.Text;
            if (key.Length < encryptedBinary.Length / 8)
            {
                int repeatCount = encryptedBinary.Length / (8 * key.Length) + 1;
                key = key.PadRight(repeatCount * key.Length, ' ');
            }
            string keyBinary = StringToBinary(key);

            // Perform XOR operation to decrypt
            string decryptedBinary = PerformXOR(encryptedBinary, keyBinary);

            // Convert binary string to text
            string decryptedText = BinaryToString(decryptedBinary);

            // Display decrypted text
            labelDecrypted.Text = "Decrypted Word: " + decryptedText;
        }

        private string BinaryToString(string binary)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < binary.Length; i += 8)
            {
                string byteString = binary.Substring(i, 8);
                result.Append(Convert.ToChar(Convert.ToByte(byteString, 2)));
            }
            return result.ToString();
        }
    }
}