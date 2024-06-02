namespace Encryption_App.Info
{
    partial class XORInfo
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(74)))), ((int)(((byte)(67)))));
            this.btnEncrypt.BorderRadius = 10;
            this.btnEncrypt.BorderThickness = 2;
            this.btnEncrypt.CustomizableEdges = customizableEdges1;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(102)))), ((int)(((byte)(3)))));
            this.btnEncrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(233, 187);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnEncrypt.Size = new System.Drawing.Size(140, 43);
            this.btnEncrypt.TabIndex = 16;
            this.btnEncrypt.Text = "Close";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 118);
            this.label2.TabIndex = 15;
            this.label2.Text = "XOR Encryption is an encryption method used to encrypt data and is hard to crack " +
    "by brute-force method, i.e generating random encryption keys to match with the c" +
    "orrect one. ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Playground", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(102)))), ((int)(((byte)(3)))));
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "XOR CIPHER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XORInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(606, 251);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XORInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XORInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEncrypt;
        private Label label2;
        private Label label1;
    }
}