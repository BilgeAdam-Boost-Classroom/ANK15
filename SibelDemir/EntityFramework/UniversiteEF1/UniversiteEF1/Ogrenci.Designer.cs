namespace UniversiteEF1
{
    partial class Ogrenci
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblsecilenOgrenci = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dGWOgrenciler = new DataGridView();
            label1 = new Label();
            txtNumara = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dGWOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(12, 24);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(12, 53);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblsecilenOgrenci
            // 
            lblsecilenOgrenci.AutoSize = true;
            lblsecilenOgrenci.Location = new Point(184, 202);
            lblsecilenOgrenci.Name = "lblsecilenOgrenci";
            lblsecilenOgrenci.Size = new Size(92, 15);
            lblsecilenOgrenci.TabIndex = 2;
            lblsecilenOgrenci.Text = "Seçilen Ögrenci:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(68, 21);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(68, 50);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(68, 108);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(68, 137);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 23);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(68, 166);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dGWOgrenciler
            // 
            dGWOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWOgrenciler.Location = new Point(184, 21);
            dGWOgrenciler.Name = "dGWOgrenciler";
            dGWOgrenciler.Size = new Size(781, 168);
            dGWOgrenciler.TabIndex = 8;
            dGWOgrenciler.CellClick += dGWOgrenciler_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 9;
            label1.Text = "Numara";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(68, 79);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(100, 23);
            txtNumara.TabIndex = 10;
            // 
            // Ogrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 235);
            Controls.Add(txtNumara);
            Controls.Add(label1);
            Controls.Add(dGWOgrenciler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblsecilenOgrenci);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Ogrenci";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dGWOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblsecilenOgrenci;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dGWOgrenciler;
        private Label label1;
        private TextBox txtNumara;
    }
}