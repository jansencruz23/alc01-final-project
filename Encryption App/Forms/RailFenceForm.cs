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
    public partial class RailFenceForm : Form
    {
        private int _rails; 
        public RailFenceForm()
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

            int.TryParse(txtKey.Text, out _rails);
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

        private string Encrypt(string input)
        {
            var letters = new string[_rails];
            var currentRail = 0;
            var descending = true;

            for (int i = 0; i < input.Length; i++)
            {
                letters[currentRail] += input[i];
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

            return string.Concat(letters);
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
            var form = new MainMenu();
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
    }
}
