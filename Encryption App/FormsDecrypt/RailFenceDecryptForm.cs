using Encryption_App.Forms;
using Encryption_App.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_App.FormsDecrypt
{
    public partial class RailFenceDecryptForm : Form
    {
        private int _rails;
        public RailFenceDecryptForm()
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
                int.TryParse(txtKey.Text, out _rails);
                var input = txtInput.Text;
                var encryptedText = Decrypt(input);

                panelAnswer.Visible = true;
                lblResult.Text = encryptedText;
            }
            catch
            {
                MessageBox.Show("Please enter a valid message or key");
            }
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

            int.TryParse(txtKey.Text, out int key);
            if (key < 2)
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

        private string Decrypt(string input)
        {
            var letterSizes = new int[_rails + 1];
            letterSizes[0] = 0;
            var currentRail = 0;
            var descending = true;

            for (int i = 0; i < input.Length; i++)
            {
                letterSizes[currentRail + 1]++;
                if (descending)
                {
                    if (currentRail + 1 == _rails)
                    {
                        descending = false;
                        currentRail--;
                    }
                    else
                    {
                        currentRail++;
                    }
                }
                else
                {
                    if (currentRail == 0)
                    {
                        descending = true;
                        currentRail++;
                    }
                    else
                    {
                        currentRail--;
                    }
                }
            }

            var letters = new string[_rails];
            var total = 0;

            for (int i = 0; i < _rails; i++)
            {
                total += letterSizes[i];
                letters[i] = input.Substring(total, letterSizes[i + 1]);
            }

            var output = "";
            var letterCounts = new int[_rails];
            currentRail = 0;

            for (int i = 0; i < input.Length; i++)
            {
                output += letters[currentRail][letterCounts[currentRail]];
                letterCounts[currentRail]++;
                if (descending)
                {
                    if (currentRail + 1 == _rails)
                    {
                        descending = false;
                        currentRail--;
                    }
                    else
                    {
                        currentRail++;
                    }
                }
                else
                {
                    if (currentRail == 0)
                    {
                        descending = true;
                        currentRail++;
                    }
                    else
                    {
                        currentRail--;
                    }
                }
            }
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
            var form = new ChoiceDecryptionForm();
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var form = new RailFenceInfo();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new RailFenceInfo();
            form.ShowDialog();
        }
    }
}
