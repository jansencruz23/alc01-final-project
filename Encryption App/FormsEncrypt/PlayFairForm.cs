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
    public partial class PlayFairForm : Form
    {
        private string _key;
        public PlayFairForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            HideErrors();

            _key = txtKey.Text;
            var input = txtInput.Text;
            var encryptedText = Encrypt(input);

            panelAnswer.Visible = true;
            lblResult.Text = encryptedText;
        }

        private bool ValidateInputs()
        {
            var isValid = true;
            var message = txtInput.Text;
            if (string.IsNullOrWhiteSpace(message))
            {
                lblMessageError.Visible = true;
                isValid = false;
            }
            else
            {
                lblMessageError.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
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

        private string Encrypt(string input)
        {
            // Implementation of Playfair cipher encryption
            // This is a placeholder implementation and needs to be replaced with actual encryption logic.
            string output = PlayfairCipherEncrypt(input, _key);
            return output;
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


        private char[,] CreatePlayfairMatrix(string key)
        {
            char[,] matrix = new char[5, 5];
            bool[] used = new bool[26];
            used['J' - 'A'] = true; // 'J' is not used in Playfair cipher, 'I' is used instead

            int row = 0, col = 0;
            foreach (char c in key)
            {
                if (!used[c - 'A'])
                {
                    matrix[row, col] = c;
                    used[c - 'A'] = true;
                    if (++col == 5)
                    {
                        col = 0;
                        row++;
                    }
                }
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (!used[c - 'A'])
                {
                    matrix[row, col] = c;
                    used[c - 'A'] = true;
                    if (++col == 5)
                    {
                        col = 0;
                        row++;
                    }
                }
            }

            return matrix;
        }

        private string PlayfairCipherEncrypt(string input, string key)
        {
            // Remove spaces and convert to uppercase
            input = input.Replace(" ", "").ToUpper().Replace("J", "I");
            key = key.Replace(" ", "").ToUpper();

            // Create the 5x5 matrix
            char[,] matrix = CreatePlayfairMatrix(key);

            // Adjust input length (insert X between repeated letters)
            StringBuilder adjustedInput = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 < input.Length && input[i] == input[i + 1])
                {
                    adjustedInput.Append(input[i]);
                    adjustedInput.Append('X');
                }
                else
                {
                    adjustedInput.Append(input[i]);
                }
            }

            if (adjustedInput.Length % 2 != 0)
            {
                adjustedInput.Append('X');
            }

            // Encrypt the input text
            return EncryptPlayfair(adjustedInput.ToString(), matrix);
        }

        private string EncryptPlayfair(string input, char[,] matrix)
        {
            StringBuilder result = new StringBuilder(input.Length);

            for (int i = 0; i < input.Length; i += 2)
            {
                char a = input[i];
                char b = input[i + 1];
                (int rowA, int colA) = FindPosition(a, matrix);
                (int rowB, int colB) = FindPosition(b, matrix);

                if (rowA == rowB)
                {
                    result.Append(matrix[rowA, (colA + 1) % 5]);
                    result.Append(matrix[rowB, (colB + 1) % 5]);
                }
                else if (colA == colB)
                {
                    result.Append(matrix[(rowA + 1) % 5, colA]);
                    result.Append(matrix[(rowB + 1) % 5, colB]);
                }
                else
                {
                    result.Append(matrix[rowA, colB]);
                    result.Append(matrix[rowB, colA]);
                }
            }

            return result.ToString();
        }

        private (int, int) FindPosition(char c, char[,] matrix)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (matrix[row, col] == c)
                    {
                        return (row, col);
                    }
                }
            }
            throw new ArgumentException("Character not found in matrix");
        }
    }
}
