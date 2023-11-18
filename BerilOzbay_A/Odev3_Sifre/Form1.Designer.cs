namespace Odev3_Sifre
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
            label1 = new Label();
            label2 = new Label();
            tbAd = new TextBox();
            tbSifre = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 79);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanici Adi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 122);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Parola:";
            // 
            // tbAd
            // 
            tbAd.Location = new Point(278, 76);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(138, 27);
            tbAd.TabIndex = 2;
            // 
            // tbSifre
            // 
            tbSifre.Location = new Point(278, 119);
            tbSifre.Name = "tbSifre";
            tbSifre.Size = new Size(138, 27);
            tbSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(235, 188);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(181, 39);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giris Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGirisYap);
            Controls.Add(tbSifre);
            Controls.Add(tbAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbAd;
        private TextBox tbSifre;
        private Button btnGirisYap;
    }
}