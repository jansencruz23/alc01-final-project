using Encryption_App.Info;
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
    public partial class XORForm : Form
    {
        public XORForm()
        {
            InitializeComponent();
        }
        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            HideErrors();


            //inputs
            string text = txtInput.Text;
            string key = txtKey.Text;

            // Encrypt the text
            string encryptedText = Encrypt(text, key);

            // Display encrypted text
            lblResult.Text = encryptedText;

            panelAnswer.Visible = true;
        }

        private string Encrypt(string word, string key)
        {
            StringBuilder encryptedWord = new StringBuilder();   //combine each string into one, para di nag mag interate each one, builder ng .NET na bahala 


            for (int i = 0; i < word.Length; i++) //iterate to all the letters
            {
                int wordAscii = (int)word[i]; //convert the i[] index of the word into binary into int

                int keyAscii = (int)key[i % key.Length]; // Ensure key is repeated if shorter than word based on the same index kaya may module key length
                //also coconvert nya yung key na letter sa binary basehan din sa i[] index nung key pero gawin int na non siya after

                int xorResult = wordAscii ^ keyAscii; //XOR


                string binaryResult = Convert.ToString(xorResult, 2).PadLeft(8,'0'); //gagawin nyang string yung binary 2 bit binary na tig 8bits, yung padding pag dagdag lang ng zero para 8bits siya
                encryptedWord.Append(binaryResult + " "); //taga append lang ng space
            }
            return encryptedWord.ToString().Trim();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new XORInfo();
            form.ShowDialog();
        }
    }
}