namespace ANK15Okul
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvDiplomalar = new System.Windows.Forms.DataGridView();
            this.lblSecilenDiploma = new System.Windows.Forms.Label();
            this.lblSecilenDers = new System.Windows.Forms.Label();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtDersKod = new System.Windows.Forms.TextBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSecilenDanisman = new System.Windows.Forms.Label();
            this.dgvDanismanlar = new System.Windows.Forms.DataGridView();
            this.btnDanismanSil = new System.Windows.Forms.Button();
            this.btnDanismanGuncelle = new System.Windows.Forms.Button();
            this.btnDanismanEkle = new System.Windows.Forms.Button();
            this.txtDanismanSoyad = new System.Windows.Forms.TextBox();
            this.txtDanismanAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOgrenciEkrani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiplomalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanismanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diploma No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diploma Tarih:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(149, 30);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(138, 23);
            this.txtNo.TabIndex = 2;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(149, 70);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(138, 23);
            this.txtTarih.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(50, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(53, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(130, 117);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(234, 117);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(53, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvDiplomalar
            // 
            this.dgvDiplomalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiplomalar.Location = new System.Drawing.Point(50, 161);
            this.dgvDiplomalar.Name = "dgvDiplomalar";
            this.dgvDiplomalar.RowTemplate.Height = 25;
            this.dgvDiplomalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiplomalar.Size = new System.Drawing.Size(249, 304);
            this.dgvDiplomalar.TabIndex = 7;
            this.dgvDiplomalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiplomalar_CellClick);
            // 
            // lblSecilenDiploma
            // 
            this.lblSecilenDiploma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenDiploma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenDiploma.Location = new System.Drawing.Point(50, 468);
            this.lblSecilenDiploma.Name = "lblSecilenDiploma";
            this.lblSecilenDiploma.Size = new System.Drawing.Size(249, 83);
            this.lblSecilenDiploma.TabIndex = 8;
            this.lblSecilenDiploma.Text = "Secilen Diploma:";
            // 
            // lblSecilenDers
            // 
            this.lblSecilenDers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenDers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenDers.Location = new System.Drawing.Point(343, 468);
            this.lblSecilenDers.Name = "lblSecilenDers";
            this.lblSecilenDers.Size = new System.Drawing.Size(249, 83);
            this.lblSecilenDers.TabIndex = 17;
            this.lblSecilenDers.Text = "Seçilen Ders:";
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(343, 202);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.RowTemplate.Height = 25;
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(249, 263);
            this.dgvDersler.TabIndex = 16;
            this.dgvDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDersler_CellClick);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(527, 158);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(53, 23);
            this.btnDersSil.TabIndex = 15;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Location = new System.Drawing.Point(423, 158);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(76, 23);
            this.btnDersGuncelle.TabIndex = 14;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(343, 158);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(53, 23);
            this.btnDersEkle.TabIndex = 13;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtDersKod
            // 
            this.txtDersKod.Location = new System.Drawing.Point(442, 70);
            this.txtDersKod.Name = "txtDersKod";
            this.txtDersKod.Size = new System.Drawing.Size(138, 23);
            this.txtDersKod.TabIndex = 12;
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(442, 30);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(138, 23);
            this.txtDersAd.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ders Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ders Adı:";
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(442, 114);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(138, 23);
            this.txtDersKredi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ders Kredisi:";
            // 
            // lblSecilenDanisman
            // 
            this.lblSecilenDanisman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenDanisman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenDanisman.Location = new System.Drawing.Point(626, 465);
            this.lblSecilenDanisman.Name = "lblSecilenDanisman";
            this.lblSecilenDanisman.Size = new System.Drawing.Size(249, 86);
            this.lblSecilenDanisman.TabIndex = 29;
            this.lblSecilenDanisman.Text = "Secilen Danışman:";
            // 
            // dgvDanismanlar
            // 
            this.dgvDanismanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanismanlar.Location = new System.Drawing.Point(626, 158);
            this.dgvDanismanlar.Name = "dgvDanismanlar";
            this.dgvDanismanlar.RowTemplate.Height = 25;
            this.dgvDanismanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanismanlar.Size = new System.Drawing.Size(249, 304);
            this.dgvDanismanlar.TabIndex = 28;
            this.dgvDanismanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanismanlar_CellClick);
            // 
            // btnDanismanSil
            // 
            this.btnDanismanSil.Location = new System.Drawing.Point(810, 114);
            this.btnDanismanSil.Name = "btnDanismanSil";
            this.btnDanismanSil.Size = new System.Drawing.Size(53, 23);
            this.btnDanismanSil.TabIndex = 27;
            this.btnDanismanSil.Text = "Sil";
            this.btnDanismanSil.UseVisualStyleBackColor = true;
            this.btnDanismanSil.Click += new System.EventHandler(this.btnDanismanSil_Click);
            // 
            // btnDanismanGuncelle
            // 
            this.btnDanismanGuncelle.Location = new System.Drawing.Point(706, 114);
            this.btnDanismanGuncelle.Name = "btnDanismanGuncelle";
            this.btnDanismanGuncelle.Size = new System.Drawing.Size(76, 23);
            this.btnDanismanGuncelle.TabIndex = 26;
            this.btnDanismanGuncelle.Text = "Güncelle";
            this.btnDanismanGuncelle.UseVisualStyleBackColor = true;
            this.btnDanismanGuncelle.Click += new System.EventHandler(this.btnDanismanGuncelle_Click);
            // 
            // btnDanismanEkle
            // 
            this.btnDanismanEkle.Location = new System.Drawing.Point(626, 114);
            this.btnDanismanEkle.Name = "btnDanismanEkle";
            this.btnDanismanEkle.Size = new System.Drawing.Size(53, 23);
            this.btnDanismanEkle.TabIndex = 25;
            this.btnDanismanEkle.Text = "Ekle";
            this.btnDanismanEkle.UseVisualStyleBackColor = true;
            this.btnDanismanEkle.Click += new System.EventHandler(this.btnDanismanEkle_Click);
            // 
            // txtDanismanSoyad
            // 
            this.txtDanismanSoyad.Location = new System.Drawing.Point(725, 67);
            this.txtDanismanSoyad.Name = "txtDanismanSoyad";
            this.txtDanismanSoyad.Size = new System.Drawing.Size(138, 23);
            this.txtDanismanSoyad.TabIndex = 24;
            // 
            // txtDanismanAd
            // 
            this.txtDanismanAd.Location = new System.Drawing.Point(725, 27);
            this.txtDanismanAd.Name = "txtDanismanAd";
            this.txtDanismanAd.Size = new System.Drawing.Size(138, 23);
            this.txtDanismanAd.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Danışman Soyadı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Danışman Adı:";
            // 
            // btnOgrenciEkrani
            // 
            this.btnOgrenciEkrani.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciEkrani.Location = new System.Drawing.Point(50, 558);
            this.btnOgrenciEkrani.Name = "btnOgrenciEkrani";
            this.btnOgrenciEkrani.Size = new System.Drawing.Size(825, 40);
            this.btnOgrenciEkrani.TabIndex = 30;
            this.btnOgrenciEkrani.Text = "Öğrenci Ekranı";
            this.btnOgrenciEkrani.UseVisualStyleBackColor = true;
            this.btnOgrenciEkrani.Click += new System.EventHandler(this.btnOgrenciEkrani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.btnOgrenciEkrani);
            this.Controls.Add(this.lblSecilenDanisman);
            this.Controls.Add(this.dgvDanismanlar);
            this.Controls.Add(this.btnDanismanSil);
            this.Controls.Add(this.btnDanismanGuncelle);
            this.Controls.Add(this.btnDanismanEkle);
            this.Controls.Add(this.txtDanismanSoyad);
            this.Controls.Add(this.txtDanismanAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSecilenDers);
            this.Controls.Add(this.dgvDersler);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.txtDersKod);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSecilenDiploma);
            this.Controls.Add(this.dgvDiplomalar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiplomalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanismanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private TextBox txtTarih;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvDiplomalar;
        private Label lblSecilenDiploma;
        private Label lblSecilenDers;
        private DataGridView dgvDersler;
        private Button btnDersSil;
        private Button btnDersGuncelle;
        private Button btnDersEkle;
        private TextBox txtDersKod;
        private TextBox txtDersAd;
        private Label label4;
        private Label label5;
        private TextBox txtDersKredi;
        private Label label7;
        private Label lblSecilenDanisman;
        private DataGridView dgvDanismanlar;
        private Button btnDanismanSil;
        private Button btnDanismanGuncelle;
        private Button btnDanismanEkle;
        private TextBox txtDanismanSoyad;
        private TextBox txtDanismanAd;
        private Label label6;
        private Label label8;
        private Button btnOgrenciEkrani;
    }
}