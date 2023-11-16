namespace calisan_bilgileri
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
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtYas = new TextBox();
            txtTC = new TextBox();
            btnCalisanEkle = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 116);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 157);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 0;
            label3.Text = "Yaş:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 211);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 0;
            label4.Text = "T.C";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(177, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(177, 110);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(177, 157);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(150, 31);
            txtYas.TabIndex = 2;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(177, 211);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(150, 31);
            txtTC.TabIndex = 3;
            // 
            // btnCalisanEkle
            // 
            btnCalisanEkle.Location = new Point(169, 286);
            btnCalisanEkle.Name = "btnCalisanEkle";
            btnCalisanEkle.Size = new Size(158, 49);
            btnCalisanEkle.TabIndex = 4;
            btnCalisanEkle.Text = "Çalışan Ekle";
            btnCalisanEkle.UseVisualStyleBackColor = true;
            btnCalisanEkle.Click += btnCalisanEkle_Click;
            // 
            // listBox1
            // 
            listBox1.DisplayMember = "TC";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(358, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(261, 279);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 450);
            Controls.Add(listBox1);
            Controls.Add(btnCalisanEkle);
            Controls.Add(txtTC);
            Controls.Add(txtYas);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private TextBox txtTC;
        private Button btnCalisanEkle;
        private ListBox listBox1;
    }
}