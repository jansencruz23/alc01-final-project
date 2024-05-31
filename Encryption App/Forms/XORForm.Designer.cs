namespace Encryption_App.Forms
{
    partial class XORForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button_Encrypt = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbWord = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbKey = new Guna.UI2.WinForms.Guna2TextBox();
            labelEncrypted = new Guna.UI2.WinForms.Guna2HtmlLabel();
            button_Decrypt = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // button_Encrypt
            // 
            button_Encrypt.CustomizableEdges = customizableEdges9;
            button_Encrypt.DisabledState.BorderColor = Color.DarkGray;
            button_Encrypt.DisabledState.CustomBorderColor = Color.DarkGray;
            button_Encrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_Encrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_Encrypt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Encrypt.ForeColor = Color.White;
            button_Encrypt.Location = new Point(88, 310);
            button_Encrypt.Name = "button_Encrypt";
            button_Encrypt.ShadowDecoration.CustomizableEdges = customizableEdges10;
            button_Encrypt.Size = new Size(180, 45);
            button_Encrypt.TabIndex = 0;
            button_Encrypt.Text = "Encrypt";
            button_Encrypt.Click += button_Encrypt_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(88, 109);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(97, 17);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // tbWord
            // 
            tbWord.CustomizableEdges = customizableEdges11;
            tbWord.DefaultText = "";
            tbWord.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbWord.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbWord.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbWord.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbWord.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbWord.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbWord.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbWord.Location = new Point(88, 132);
            tbWord.Name = "tbWord";
            tbWord.PasswordChar = '\0';
            tbWord.PlaceholderText = "";
            tbWord.SelectedText = "";
            tbWord.ShadowDecoration.CustomizableEdges = customizableEdges12;
            tbWord.Size = new Size(200, 36);
            tbWord.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(88, 194);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(97, 17);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "guna2HtmlLabel2";
            // 
            // tbKey
            // 
            tbKey.CustomizableEdges = customizableEdges13;
            tbKey.DefaultText = "";
            tbKey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbKey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbKey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbKey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbKey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbKey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbKey.Location = new Point(88, 217);
            tbKey.Name = "tbKey";
            tbKey.PasswordChar = '\0';
            tbKey.PlaceholderText = "";
            tbKey.SelectedText = "";
            tbKey.ShadowDecoration.CustomizableEdges = customizableEdges14;
            tbKey.Size = new Size(200, 36);
            tbKey.TabIndex = 4;
            // 
            // labelEncrypted
            // 
            labelEncrypted.BackColor = Color.Transparent;
            labelEncrypted.Location = new Point(439, 132);
            labelEncrypted.Name = "labelEncrypted";
            labelEncrypted.Size = new Size(110, 17);
            labelEncrypted.TabIndex = 5;
            labelEncrypted.Text = "MAGIC WORD HERE";
            // 
            // button_Decrypt
            // 
            button_Decrypt.CustomizableEdges = customizableEdges15;
            button_Decrypt.DisabledState.BorderColor = Color.DarkGray;
            button_Decrypt.DisabledState.CustomBorderColor = Color.DarkGray;
            button_Decrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_Decrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_Decrypt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Decrypt.ForeColor = Color.White;
            button_Decrypt.Location = new Point(326, 310);
            button_Decrypt.Name = "button_Decrypt";
            button_Decrypt.ShadowDecoration.CustomizableEdges = customizableEdges16;
            button_Decrypt.Size = new Size(180, 45);
            button_Decrypt.TabIndex = 6;
            button_Decrypt.Text = "guna2Button1";
            // 
            // XORForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 239, 212);
            ClientSize = new Size(716, 450);
            Controls.Add(button_Decrypt);
            Controls.Add(labelEncrypted);
            Controls.Add(tbKey);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(tbWord);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(button_Encrypt);
            Name = "XORForm";
            Text = "XORForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_Encrypt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbWord;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbKey;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelEncrypted;
        private Guna.UI2.WinForms.Guna2Button button_Decrypt;
    }
}