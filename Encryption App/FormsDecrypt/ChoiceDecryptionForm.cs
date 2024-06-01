using Encryption_App.FormsDecrypt;
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
    public partial class ChoiceDecryptionForm : Form
    {
        public ChoiceDecryptionForm()
        {
            InitializeComponent();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ColumnarDecryptionForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new XORFormDecrypt();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new PlayFairDecryptForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnRailFence_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new RailFenceDecryptForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new MainMenu();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }
    }
}
