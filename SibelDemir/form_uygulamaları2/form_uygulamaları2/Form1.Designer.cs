namespace form_uygulamaları2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKullanıcıAdı = new TextBox();
            txtParola = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(144, 63);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.PlaceholderText = "Kullanıcı Adı Gir";
            txtKullanıcıAdı.Size = new Size(224, 31);
            txtKullanıcıAdı.TabIndex = 0;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(144, 128);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.PlaceholderText = "Parola Gir";
            txtParola.Size = new Size(224, 31);
            txtParola.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 3;
            label2.Text = "Parola:";
            // 
            // button1
            // 
            button1.Location = new Point(157, 205);
            button1.Name = "button1";
            button1.Size = new Size(211, 68);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtParola);
            Controls.Add(txtKullanıcıAdı);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullanıcıAdı;
        private TextBox txtParola;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}