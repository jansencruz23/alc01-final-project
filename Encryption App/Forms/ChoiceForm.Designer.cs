namespace Encryption_App.Forms
{
    partial class ChoiceForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btnAES = new Guna.UI2.WinForms.Guna2Button();
            btnPlayfair = new Guna.UI2.WinForms.Guna2Button();
            btnXOR = new Guna.UI2.WinForms.Guna2Button();
            btnRailFence = new Guna.UI2.WinForms.Guna2Button();
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(254, 102, 3);
            label1.Location = new Point(2, 115);
            label1.Name = "label1";
            label1.Size = new Size(662, 156);
            label1.TabIndex = 1;
            label1.Text = "CHOOSE AN \r\nALGORITHM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAES
            // 
            btnAES.BorderColor = Color.FromArgb(157, 74, 67);
            btnAES.BorderRadius = 10;
            btnAES.BorderThickness = 2;
            btnAES.CustomizableEdges = customizableEdges1;
            btnAES.DisabledState.BorderColor = Color.DarkGray;
            btnAES.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAES.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAES.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAES.FillColor = Color.FromArgb(254, 102, 3);
            btnAES.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAES.ForeColor = Color.White;
            btnAES.Location = new Point(119, 292);
            btnAES.Name = "btnAES";
            btnAES.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAES.Size = new Size(203, 49);
            btnAES.TabIndex = 9;
            btnAES.Text = "Columnar";
            btnAES.Click += btnAES_Click;
            // 
            // btnPlayfair
            // 
            btnPlayfair.BorderColor = Color.FromArgb(157, 74, 67);
            btnPlayfair.BorderRadius = 10;
            btnPlayfair.BorderThickness = 2;
            btnPlayfair.CustomizableEdges = customizableEdges3;
            btnPlayfair.DisabledState.BorderColor = Color.DarkGray;
            btnPlayfair.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlayfair.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlayfair.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlayfair.FillColor = Color.FromArgb(254, 102, 3);
            btnPlayfair.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlayfair.ForeColor = Color.White;
            btnPlayfair.Location = new Point(119, 358);
            btnPlayfair.Name = "btnPlayfair";
            btnPlayfair.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPlayfair.Size = new Size(203, 49);
            btnPlayfair.TabIndex = 10;
            btnPlayfair.Text = "Playfair Cipher";
            btnPlayfair.Click += btnPlayfair_Click;
            // 
            // btnXOR
            // 
            btnXOR.BorderColor = Color.FromArgb(157, 74, 67);
            btnXOR.BorderRadius = 10;
            btnXOR.BorderThickness = 2;
            btnXOR.CustomizableEdges = customizableEdges5;
            btnXOR.DisabledState.BorderColor = Color.DarkGray;
            btnXOR.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXOR.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXOR.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXOR.FillColor = Color.FromArgb(254, 102, 3);
            btnXOR.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnXOR.ForeColor = Color.White;
            btnXOR.Location = new Point(338, 292);
            btnXOR.Name = "btnXOR";
            btnXOR.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnXOR.Size = new Size(203, 49);
            btnXOR.TabIndex = 11;
            btnXOR.Text = "XOR Cipher";
            btnXOR.Click += btnXOR_Click;
            // 
            // btnRailFence
            // 
            btnRailFence.BorderColor = Color.FromArgb(157, 74, 67);
            btnRailFence.BorderRadius = 10;
            btnRailFence.BorderThickness = 2;
            btnRailFence.CustomizableEdges = customizableEdges7;
            btnRailFence.DisabledState.BorderColor = Color.DarkGray;
            btnRailFence.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRailFence.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRailFence.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRailFence.FillColor = Color.FromArgb(254, 102, 3);
            btnRailFence.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRailFence.ForeColor = Color.White;
            btnRailFence.Location = new Point(338, 358);
            btnRailFence.Name = "btnRailFence";
            btnRailFence.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRailFence.Size = new Size(203, 49);
            btnRailFence.TabIndex = 12;
            btnRailFence.Text = "Rail Fence";
            btnRailFence.Click += btnRailFence_Click;
            // 
            // btnHome
            // 
            btnHome.BorderColor = Color.FromArgb(157, 74, 67);
            btnHome.BorderRadius = 10;
            btnHome.BorderThickness = 2;
            btnHome.CustomizableEdges = customizableEdges9;
            btnHome.DisabledState.BorderColor = Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHome.FillColor = Color.FromArgb(254, 102, 3);
            btnHome.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnHome.Size = new Size(56, 49);
            btnHome.TabIndex = 13;
            btnHome.Click += btnHome_Click;
            // 
            // guna2Button5
            // 
            guna2Button5.BorderColor = Color.FromArgb(157, 74, 67);
            guna2Button5.BorderRadius = 10;
            guna2Button5.BorderThickness = 2;
            guna2Button5.CustomizableEdges = customizableEdges11;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.FromArgb(254, 102, 3);
            guna2Button5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Image = (Image)resources.GetObject("guna2Button5.Image");
            guna2Button5.Location = new Point(593, 12);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button5.Size = new Size(56, 49);
            guna2Button5.TabIndex = 14;
            guna2Button5.Click += guna2Button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, -260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-103, -248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(441, 382);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 239, 212);
            ClientSize = new Size(661, 494);
            Controls.Add(guna2Button5);
            Controls.Add(btnHome);
            Controls.Add(btnRailFence);
            Controls.Add(btnXOR);
            Controls.Add(btnPlayfair);
            Controls.Add(btnAES);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "ChoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChoiceForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAES;
        private Guna.UI2.WinForms.Guna2Button btnPlayfair;
        private Guna.UI2.WinForms.Guna2Button btnXOR;
        private Guna.UI2.WinForms.Guna2Button btnRailFence;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}