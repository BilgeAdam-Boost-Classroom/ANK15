namespace CodeFirstUniversite
{
    partial class OgrenciEkrani
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
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNumara = new TextBox();
            label3 = new Label();
            dgvOgrenciler = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label4 = new Label();
            label5 = new Label();
            cbxDanisman = new ComboBox();
            cbxDiploma = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(191, 93);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(204, 27);
            txtSoyadi.TabIndex = 7;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(191, 45);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(204, 27);
            txtAdi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 96);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "Ogrenci Soyadi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Ogrenci Adi:";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(191, 145);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(204, 27);
            txtNumara.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 148);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 8;
            label3.Text = "Ogrenci Numarasi:";
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(474, 36);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowHeadersWidth = 51;
            dgvOgrenciler.RowTemplate.Height = 29;
            dgvOgrenciler.Size = new Size(651, 417);
            dgvOgrenciler.TabIndex = 10;
            dgvOgrenciler.CellClick += dgvOgrenciler_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(55, 322);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(174, 322);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(301, 322);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 244);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 16;
            label4.Text = "Ogrenci Diplomasi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 198);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 14;
            label5.Text = "Ogrenci Danismani:";
            // 
            // cbxDanisman
            // 
            cbxDanisman.FormattingEnabled = true;
            cbxDanisman.Location = new Point(199, 195);
            cbxDanisman.Name = "cbxDanisman";
            cbxDanisman.Size = new Size(196, 28);
            cbxDanisman.TabIndex = 17;
            // 
            // cbxDiploma
            // 
            cbxDiploma.FormattingEnabled = true;
            cbxDiploma.Location = new Point(199, 244);
            cbxDiploma.Name = "cbxDiploma";
            cbxDiploma.Size = new Size(196, 28);
            cbxDiploma.TabIndex = 18;
            // 
            // OgrenciEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 532);
            Controls.Add(cbxDiploma);
            Controls.Add(cbxDanisman);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvOgrenciler);
            Controls.Add(txtNumara);
            Controls.Add(label3);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkrani";
            Text = "OgrenciEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label2;
        private Label label1;
        private TextBox txtNumara;
        private Label label3;
        private DataGridView dgvOgrenciler;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label4;
        private Label label5;
        private ComboBox cbxDanisman;
        private ComboBox cbxDiploma;
    }
}