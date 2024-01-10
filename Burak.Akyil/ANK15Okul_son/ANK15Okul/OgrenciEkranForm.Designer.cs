namespace ANK15Okul
{
    partial class OgrenciEkranForm
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
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOgrenciDanismani = new System.Windows.Forms.ComboBox();
            this.cmbOgrenciDiplomasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.lblSecilenOgrenci = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbNotlar = new System.Windows.Forms.ComboBox();
            this.lblSecilenOgrenciDersi = new System.Windows.Forms.Label();
            this.dgvOgrenciDersler = new System.Windows.Forms.DataGridView();
            this.btnOdGuncelle = new System.Windows.Forms.Button();
            this.btnOdSil = new System.Windows.Forms.Button();
            this.btnOdEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(129, 113);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(138, 23);
            this.txtOgrenciNo.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Numarası:";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(129, 69);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(138, 23);
            this.txtOgrenciSoyad.TabIndex = 24;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(129, 29);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(138, 23);
            this.txtOgrenciAd.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adı:";
            // 
            // cmbOgrenciDanismani
            // 
            this.cmbOgrenciDanismani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciDanismani.FormattingEnabled = true;
            this.cmbOgrenciDanismani.Location = new System.Drawing.Point(129, 160);
            this.cmbOgrenciDanismani.Name = "cmbOgrenciDanismani";
            this.cmbOgrenciDanismani.Size = new System.Drawing.Size(138, 23);
            this.cmbOgrenciDanismani.TabIndex = 27;
            // 
            // cmbOgrenciDiplomasi
            // 
            this.cmbOgrenciDiplomasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciDiplomasi.FormattingEnabled = true;
            this.cmbOgrenciDiplomasi.Location = new System.Drawing.Point(129, 208);
            this.cmbOgrenciDiplomasi.Name = "cmbOgrenciDiplomasi";
            this.cmbOgrenciDiplomasi.Size = new System.Drawing.Size(138, 23);
            this.cmbOgrenciDiplomasi.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danışmanı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Diploması:";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(39, 249);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciEkle.TabIndex = 31;
            this.btnOgrenciEkle.Text = "EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(120, 249);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciSil.TabIndex = 32;
            this.btnOgrenciSil.Text = "SİL";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(201, 249);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciGuncelle.TabIndex = 33;
            this.btnOgrenciGuncelle.Text = "GÜNCELLE";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(37, 283);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowTemplate.Height = 25;
            this.dgvOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgrenciler.Size = new System.Drawing.Size(251, 224);
            this.dgvOgrenciler.TabIndex = 34;
            this.dgvOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciler_CellClick);
            // 
            // lblSecilenOgrenci
            // 
            this.lblSecilenOgrenci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenOgrenci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenOgrenci.Location = new System.Drawing.Point(37, 510);
            this.lblSecilenOgrenci.Name = "lblSecilenOgrenci";
            this.lblSecilenOgrenci.Size = new System.Drawing.Size(249, 43);
            this.lblSecilenOgrenci.TabIndex = 35;
            this.lblSecilenOgrenci.Text = "Secilen Öğrenci:";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Öğrenci:";
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(464, 32);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(138, 23);
            this.cmbOgrenciler.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ders:";
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(464, 77);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(138, 23);
            this.cmbDersler.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Not:";
            // 
            // cmbNotlar
            // 
            this.cmbNotlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotlar.FormattingEnabled = true;
            this.cmbNotlar.Location = new System.Drawing.Point(464, 125);
            this.cmbNotlar.Name = "cmbNotlar";
            this.cmbNotlar.Size = new System.Drawing.Size(138, 23);
            this.cmbNotlar.TabIndex = 40;
            // 
            // lblSecilenOgrenciDersi
            // 
            this.lblSecilenOgrenciDersi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenOgrenciDersi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenOgrenciDersi.Location = new System.Drawing.Point(378, 452);
            this.lblSecilenOgrenciDersi.Name = "lblSecilenOgrenciDersi";
            this.lblSecilenOgrenciDersi.Size = new System.Drawing.Size(249, 101);
            this.lblSecilenOgrenciDersi.TabIndex = 43;
            this.lblSecilenOgrenciDersi.Text = "Secilen Öğrenci Dersi:";
            // 
            // dgvOgrenciDersler
            // 
            this.dgvOgrenciDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciDersler.Location = new System.Drawing.Point(379, 208);
            this.dgvOgrenciDersler.Name = "dgvOgrenciDersler";
            this.dgvOgrenciDersler.RowTemplate.Height = 25;
            this.dgvOgrenciDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgrenciDersler.Size = new System.Drawing.Size(251, 241);
            this.dgvOgrenciDersler.TabIndex = 42;
            this.dgvOgrenciDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciDersler_CellClick);
            // 
            // btnOdGuncelle
            // 
            this.btnOdGuncelle.Location = new System.Drawing.Point(541, 177);
            this.btnOdGuncelle.Name = "btnOdGuncelle";
            this.btnOdGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnOdGuncelle.TabIndex = 46;
            this.btnOdGuncelle.Text = "GÜNCELLE";
            this.btnOdGuncelle.UseVisualStyleBackColor = true;
            this.btnOdGuncelle.Click += new System.EventHandler(this.btnOdGuncelle_Click);
            // 
            // btnOdSil
            // 
            this.btnOdSil.Location = new System.Drawing.Point(460, 177);
            this.btnOdSil.Name = "btnOdSil";
            this.btnOdSil.Size = new System.Drawing.Size(75, 23);
            this.btnOdSil.TabIndex = 45;
            this.btnOdSil.Text = "SİL";
            this.btnOdSil.UseVisualStyleBackColor = true;
            this.btnOdSil.Click += new System.EventHandler(this.btnOdSil_Click);
            // 
            // btnOdEkle
            // 
            this.btnOdEkle.Location = new System.Drawing.Point(379, 177);
            this.btnOdEkle.Name = "btnOdEkle";
            this.btnOdEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOdEkle.TabIndex = 44;
            this.btnOdEkle.Text = "EKLE";
            this.btnOdEkle.UseVisualStyleBackColor = true;
            this.btnOdEkle.Click += new System.EventHandler(this.btnOdEkle_Click);
            // 
            // OgrenciEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 567);
            this.Controls.Add(this.btnOdGuncelle);
            this.Controls.Add(this.btnOdSil);
            this.Controls.Add(this.btnOdEkle);
            this.Controls.Add(this.lblSecilenOgrenciDersi);
            this.Controls.Add(this.dgvOgrenciDersler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbNotlar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.lblSecilenOgrenci);
            this.Controls.Add(this.dgvOgrenciler);
            this.Controls.Add(this.btnOgrenciGuncelle);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOgrenciDiplomasi);
            this.Controls.Add(this.cmbOgrenciDanismani);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "OgrenciEkranForm";
            this.Text = "OgrenciEkranForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOgrenciNo;
        private Label label7;
        private TextBox txtOgrenciSoyad;
        private TextBox txtOgrenciAd;
        private Label label4;
        private Label label5;
        private ComboBox cmbOgrenciDanismani;
        private ComboBox cmbOgrenciDiplomasi;
        private Label label1;
        private Label label2;
        private Button btnOgrenciEkle;
        private Button btnOgrenciSil;
        private Button btnOgrenciGuncelle;
        private DataGridView dgvOgrenciler;
        private Label lblSecilenOgrenci;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private ComboBox cmbOgrenciler;
        private Label label6;
        private ComboBox cmbDersler;
        private Label label8;
        private ComboBox cmbNotlar;
        private Label lblSecilenOgrenciDersi;
        private DataGridView dgvOgrenciDersler;
        private Button btnOdGuncelle;
        private Button btnOdSil;
        private Button btnOdEkle;
    }
}