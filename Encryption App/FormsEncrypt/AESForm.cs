﻿using Encryption_App.Info;
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
            string message = txtInput.Text;
            string key = txtKey.Text;

            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both the message and the key.");
                return;
            }

            try
            {
                string encryptedMessage = ColumnarTranspositionCipher.EncryptMessage(message, key);
                richTextBox1.Text = encryptedMessage;
                panelAnswer.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid message or key.");
            }
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
            txtInput.Text = string.Empty;
            txtKey.Text = string.Empty;
            richTextBox1.Text = string.Empty;
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            lblNotif.Visible = true;
            await Task.Delay(2000);
            lblNotif.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new MainMenu();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Hide();
            var form = new ChoiceDecryptionForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtKey.Clear();
            richTextBox1.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new ColumnerInfo();
            form.ShowDialog();
        }
    }
}

