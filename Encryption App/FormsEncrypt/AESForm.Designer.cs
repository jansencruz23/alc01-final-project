namespace Encryption_App.Forms
{
    partial class AESDecryptionForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AESDecryptionForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button3 = new Guna.UI2.WinForms.Guna2Button();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 448);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 13;
            label3.Text = "Result:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(84, 479);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(412, 119);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.BorderColor = Color.FromArgb(157, 74, 67);
            button3.BorderRadius = 10;
            button3.BorderThickness = 2;
            button3.CustomizableEdges = customizableEdges11;
            button3.DisabledState.BorderColor = Color.DarkGray;
            button3.DisabledState.CustomBorderColor = Color.DarkGray;
            button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button3.FillColor = Color.FromArgb(254, 102, 3);
            button3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(293, 365);
            button3.Name = "button3";
            button3.ShadowDecoration.CustomizableEdges = customizableEdges12;
            button3.Size = new Size(203, 49);
            button3.TabIndex = 11;
            button3.Text = "Clear";
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BorderColor = Color.FromArgb(157, 74, 67);
            button1.BorderRadius = 10;
            button1.BorderThickness = 2;
            button1.CustomizableEdges = customizableEdges13;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.FromArgb(254, 102, 3);
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(84, 365);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            button1.Size = new Size(203, 49);
            button1.TabIndex = 9;
            button1.Text = "Encrypt";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 283);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 7;
            label1.Text = "Key:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 204);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 6;
            label2.Text = "Message:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.CustomizableEdges = customizableEdges15;
            textBox2.DefaultText = "";
            textBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox2.Location = new Point(84, 315);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '\0';
            textBox2.PlaceholderText = "";
            textBox2.SelectedText = "";
            textBox2.ShadowDecoration.CustomizableEdges = customizableEdges16;
            textBox2.Size = new Size(412, 43);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.CustomizableEdges = customizableEdges17;
            textBox1.DefaultText = "";
            textBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox1.Location = new Point(84, 236);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '\0';
            textBox1.PlaceholderText = "";
            textBox1.SelectedText = "";
            textBox1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            textBox1.Size = new Size(412, 43);
            textBox1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BorderColor = Color.FromArgb(157, 74, 67);
            btnBack.BorderRadius = 10;
            btnBack.BorderThickness = 2;
            btnBack.CustomizableEdges = customizableEdges19;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.FromArgb(254, 102, 3);
            btnBack.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageSize = new Size(25, 25);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnBack.Size = new Size(56, 49);
            btnBack.TabIndex = 20;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Playground", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(254, 102, 3);
            label4.Location = new Point(50, 64);
            label4.Name = "label4";
            label4.Size = new Size(479, 130);
            label4.TabIndex = 21;
            label4.Text = "COLUMNAR TRANSPOSITION";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AESDecryptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 239, 212);
            ClientSize = new Size(576, 610);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AESDecryptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Columnar Transposition";
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2Button button3;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBox2;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label label4;
    }
}