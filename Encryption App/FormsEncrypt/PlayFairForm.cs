using Encryption_App.Info;
using Microsoft.VisualBasic.Devices;
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

            try
            {
                string message = txtInput.Text;
                _key = txtKey.Text;
                string encryptedMessage = Encrypt(message, _key);

                lblResult.Text = encryptedMessage;
                panelAnswer.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            var isValid = true;
            var message = txtInput.Text;
            if (string.IsNullOrWhiteSpace(message) || Regex.IsMatch(txtInput.Text, @"\d"))
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
            if (Regex.IsMatch(txtKey.Text, @"\d"))
            {
                lblKeyError.Visible = true;
                isValid = false;
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

        private char[,] GenerateKeySquare(string key)
        {
            key = key.ToUpper().Replace('J', 'I');
            string keyString = key + "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();
            foreach (char c in keyString)
            {
                if (!sb.ToString().Contains(c) && char.IsLetter(c))
                    sb.Append(c);
            }

            char[,] keySquare = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    keySquare[i, j] = sb[i * 5 + j];
                }
            }

            return keySquare;
        }

        private (int, int) FindPosition(char[,] keySquare, char letter)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keySquare[i, j] == letter)
                        return (i, j);
                }
            }
            throw new ArgumentException("Letter not found in key square");
        }

        private string Encrypt(string plaintext, string key)
        {
            char[,] keySquare = GenerateKeySquare(key);
            plaintext = plaintext.ToUpper().Replace('J', 'I').Replace(" ", "");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                if (i + 1 >= plaintext.Length || plaintext[i] == plaintext[i + 1])
                {
                    plaintext = plaintext.Insert(i + 1, "X");
                }

                (char first, char second) = (plaintext[i], plaintext[i + 1]);
                (int r1, int c1) = FindPosition(keySquare, first);
                (int r2, int c2) = FindPosition(keySquare, second);

                if (r1 == r2)
                {
                    sb.Append(keySquare[r1, (c1 + 1) % 5]);
                    sb.Append(keySquare[r2, (c2 + 1) % 5]);
                }
                else if (c1 == c2)
                {
                    sb.Append(keySquare[(r1 + 1) % 5, c1]);
                    sb.Append(keySquare[(r2 + 1) % 5, c2]);
                }
                else
                {
                    sb.Append(keySquare[r1, c2]);
                    sb.Append(keySquare[r2, c1]);
                }
            }

            return sb.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new PlayFairInfo();
            form.ShowDialog();
        }
    }
}
