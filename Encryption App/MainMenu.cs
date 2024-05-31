using Encryption_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_App
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ChoiceForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ChoiceDecryptionForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }
    }
}
