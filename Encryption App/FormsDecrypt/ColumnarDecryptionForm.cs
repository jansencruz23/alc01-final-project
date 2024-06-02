using Encryption_App.Forms;
using Encryption_App.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_App.FormsDecrypt
{
    public partial class ColumnarDecryptionForm : Form
    {
        public ColumnarDecryptionForm()
        {
            InitializeComponent();
        }

        private void ColumnarDecryptionForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            txtKey.Text = string.Empty;
            richTextBox1.Text = string.Empty;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cipherText = txtInput.Text;
            string key = txtKey.Text;

            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both the ciphertext and the key.");
                return;
            }

            try
            {
                string decryptedMessage = ColumnarTranspositionCipher.DecryptMessage(cipherText, key);
                richTextBox1.Text = decryptedMessage;
                panelAnswer.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid message or key");
            }   
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new ColumnerInfo();
            form.ShowDialog();
        }

        private void ColumnarDecryptionForm_Load_1(object sender, EventArgs e)
        {

        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            lblNotif.Visible = true;
            await Task.Delay(2000);
            lblNotif.Visible = false;
        }
    }
}
