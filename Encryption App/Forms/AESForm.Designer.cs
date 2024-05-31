namespace Encryption_App.Forms
{
    partial class AESForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Guna.UI2.WinForms.Guna2Button();
            button3 = new Guna.UI2.WinForms.Guna2Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CustomizableEdges = customizableEdges1;
            textBox1.DefaultText = "";
            textBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox1.Location = new Point(85, 106);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '\0';
            textBox1.PlaceholderText = "";
            textBox1.SelectedText = "";
            textBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBox1.Size = new Size(412, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.CustomizableEdges = customizableEdges3;
            textBox2.DefaultText = "";
            textBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBox2.Location = new Point(85, 185);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '\0';
            textBox2.PlaceholderText = "";
            textBox2.SelectedText = "";
            textBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBox2.Size = new Size(412, 43);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 74);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 6;
            label2.Text = "Message:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 153);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 7;
            label1.Text = "Key:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BorderColor = Color.FromArgb(157, 74, 67);
            button1.BorderRadius = 10;
            button1.BorderThickness = 2;
            button1.CustomizableEdges = customizableEdges5;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.FromArgb(254, 102, 3);
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(85, 235);
            button1.Name = "button1";
            button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button1.Size = new Size(203, 49);
            button1.TabIndex = 9;
            button1.Text = "Encrypt";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BorderColor = Color.FromArgb(157, 74, 67);
            button2.BorderRadius = 10;
            button2.BorderThickness = 2;
            button2.CustomizableEdges = customizableEdges7;
            button2.DisabledState.BorderColor = Color.DarkGray;
            button2.DisabledState.CustomBorderColor = Color.DarkGray;
            button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button2.FillColor = Color.FromArgb(254, 102, 3);
            button2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(85, 290);
            button2.Name = "button2";
            button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            button2.Size = new Size(203, 49);
            button2.TabIndex = 10;
            button2.Text = "Decrpyt";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BorderColor = Color.FromArgb(157, 74, 67);
            button3.BorderRadius = 10;
            button3.BorderThickness = 2;
            button3.CustomizableEdges = customizableEdges9;
            button3.DisabledState.BorderColor = Color.DarkGray;
            button3.DisabledState.CustomBorderColor = Color.DarkGray;
            button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button3.FillColor = Color.FromArgb(254, 102, 3);
            button3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(294, 235);
            button3.Name = "button3";
            button3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            button3.Size = new Size(203, 49);
            button3.TabIndex = 11;
            button3.Text = "Clear";
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(85, 431);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(412, 176);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 400);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 13;
            label3.Text = "Result:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // AESForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 239, 212);
            ClientSize = new Size(576, 658);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AESForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Columnar Transposition";
            Load += AESForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBox2;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button3;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}