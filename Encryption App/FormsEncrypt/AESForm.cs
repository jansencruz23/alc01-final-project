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
    public partial class AESDecryptionForm : Form
    {
        public AESDecryptionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            string key = textBox2.Text;

            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both the message and the key.");
                return;
            }

            string encryptedMessage = ColumnarTranspositionCipher.EncryptMessage(message, key);
            richTextBox1.Text = encryptedMessage;
        }

        public static class ColumnarTranspositionCipher
        {
            private static Dictionary<char, int> keyMap;

            private static void SetPermutationOrder(string key)
            {
                keyMap = new Dictionary<char, int>();
                var sortedKey = key.ToCharArray();
                Array.Sort(sortedKey);

                for (int i = 0; i < sortedKey.Length; i++)
                {
                    keyMap[sortedKey[i]] = i;
                }
            }

            public static string EncryptMessage(string msg, string key)
            {
                SetPermutationOrder(key);

                int col = key.Length;
                int row = (int)Math.Ceiling((double)msg.Length / col);

                char[,] matrix = new char[row, col];

                for (int i = 0, k = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (k < msg.Length)
                        {
                            char ch = msg[k];
                            matrix[i, j] = ch;
                            k++;
                        }
                        else
                        {
                            matrix[i, j] = '_';
                        }
                    }
                }

                System.Text.StringBuilder cipher = new System.Text.StringBuilder();

                foreach (var entry in keyMap.OrderBy(k => k.Value))
                {
                    int columnIndex = entry.Value;

                    for (int i = 0; i < row; i++)
                    {
                        cipher.Append(matrix[i, columnIndex]);
                    }
                }

                return cipher.ToString();
            }

            public static string DecryptMessage(string cipher, string key)
            {
                SetPermutationOrder(key);

                int col = key.Length;
                int row = (int)Math.Ceiling((double)cipher.Length / col);

                char[,] matrix = new char[row, col];

                int k = 0;
                foreach (var entry in keyMap.OrderBy(k => k.Value))
                {
                    int columnIndex = entry.Value;

                    for (int i = 0; i < row; i++)
                    {
                        matrix[i, columnIndex] = cipher[k++];
                    }
                }

                System.Text.StringBuilder msg = new System.Text.StringBuilder();

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (matrix[i, j] != '_')
                        {
                            msg.Append(matrix[i, j]);
                        }
                    }
                }

                return msg.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            richTextBox1.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ChoiceForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }
    }
}

