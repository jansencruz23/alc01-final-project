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
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new AESDecryptionForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new XORForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new PlayFairForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnRailFence_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new RailFenceForm();
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
