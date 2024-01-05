namespace Ex03_01_2024
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
            txtNo = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dataGridDiploamalar = new DataGridView();
            dtTimeTarih = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtOgrenciAd = new TextBox();
            txtOgrenciSoyad = new TextBox();
            dtOgrenciPiker = new DateTimePicker();
            BtnSil2 = new Button();
            btnGunc2 = new Button();
            btnEkle2 = new Button();
            label6 = new Label();
            cbDanismanOgrenci = new ComboBox();
            cbOgrenciDiplama = new ComboBox();
            label7 = new Label();
            txtDanismanSoyad = new TextBox();
            txtDanismanAd = new TextBox();
            label8 = new Label();
            label9 = new Label();
            BtnSil3 = new Button();
            BtnGunc3 = new Button();
            BtnEkle3 = new Button();
            dataGridDanisman = new DataGridView();
            dataGridOgrenci = new DataGridView();
            dersKodu = new TextBox();
            dersAdi = new TextBox();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtKredi = new TextBox();
            dersKredi = new Label();
            dataGridDers = new DataGridView();
            comboOgreci2 = new ComboBox();
            comboDers2 = new ComboBox();
            button4 = new Button();
            label12 = new Label();
            label13 = new Label();
            txtNot = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridDiploamalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDanisman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOgrenci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Diploma No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Diploma Tarih:";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(158, 28);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(100, 23);
            txtNo.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(44, 134);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(56, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(121, 134);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(56, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(202, 134);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(56, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridDiploamalar
            // 
            dataGridDiploamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDiploamalar.Location = new Point(24, 318);
            dataGridDiploamalar.Name = "dataGridDiploamalar";
            dataGridDiploamalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDiploamalar.Size = new Size(223, 223);
            dataGridDiploamalar.TabIndex = 7;
            dataGridDiploamalar.CellClick += dataGridDiploamalar_CellClick;
            // 
            // dtTimeTarih
            // 
            dtTimeTarih.Location = new Point(158, 75);
            dtTimeTarih.Name = "dtTimeTarih";
            dtTimeTarih.Size = new Size(200, 23);
            dtTimeTarih.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(635, 36);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "Ogrenci Adi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(625, 83);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 10;
            label4.Text = "Ogrenci Soyadi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(630, 134);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 11;
            label5.Text = "Dogum Tarihi";
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(729, 33);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(100, 23);
            txtOgrenciAd.TabIndex = 12;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(729, 78);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(100, 23);
            txtOgrenciSoyad.TabIndex = 13;
            // 
            // dtOgrenciPiker
            // 
            dtOgrenciPiker.Location = new Point(729, 132);
            dtOgrenciPiker.Name = "dtOgrenciPiker";
            dtOgrenciPiker.Size = new Size(200, 23);
            dtOgrenciPiker.TabIndex = 14;
            // 
            // BtnSil2
            // 
            BtnSil2.Location = new Point(531, 134);
            BtnSil2.Name = "BtnSil2";
            BtnSil2.Size = new Size(56, 23);
            BtnSil2.TabIndex = 17;
            BtnSil2.Tag = "DanismanDelete";
            BtnSil2.Text = "Sil";
            BtnSil2.UseVisualStyleBackColor = true;
            BtnSil2.Click += BtnDelete;
            // 
            // btnGunc2
            // 
            btnGunc2.Location = new Point(450, 134);
            btnGunc2.Name = "btnGunc2";
            btnGunc2.Size = new Size(56, 23);
            btnGunc2.TabIndex = 16;
            btnGunc2.Tag = "danismanGuncelle";
            btnGunc2.Text = "Guncelle";
            btnGunc2.UseVisualStyleBackColor = true;
            btnGunc2.Click += btnUpdate;
            // 
            // btnEkle2
            // 
            btnEkle2.Location = new Point(373, 134);
            btnEkle2.Name = "btnEkle2";
            btnEkle2.Size = new Size(56, 23);
            btnEkle2.TabIndex = 15;
            btnEkle2.Tag = "danismanEkle";
            btnEkle2.Text = "Ekle";
            btnEkle2.UseVisualStyleBackColor = true;
            btnEkle2.Click += btnAdd;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(645, 185);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 18;
            label6.Text = "Dansimani";
            // 
            // cbDanismanOgrenci
            // 
            cbDanismanOgrenci.FormattingEnabled = true;
            cbDanismanOgrenci.Location = new Point(729, 177);
            cbDanismanOgrenci.Name = "cbDanismanOgrenci";
            cbDanismanOgrenci.Size = new Size(121, 23);
            cbDanismanOgrenci.TabIndex = 19;
            // 
            // cbOgrenciDiplama
            // 
            cbOgrenciDiplama.FormattingEnabled = true;
            cbOgrenciDiplama.Location = new Point(729, 215);
            cbOgrenciDiplama.Name = "cbOgrenciDiplama";
            cbOgrenciDiplama.Size = new Size(121, 23);
            cbOgrenciDiplama.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(645, 223);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 20;
            label7.Text = "Diplomasi";
            // 
            // txtDanismanSoyad
            // 
            txtDanismanSoyad.Location = new Point(487, 78);
            txtDanismanSoyad.Name = "txtDanismanSoyad";
            txtDanismanSoyad.Size = new Size(100, 23);
            txtDanismanSoyad.TabIndex = 25;
            // 
            // txtDanismanAd
            // 
            txtDanismanAd.Location = new Point(487, 33);
            txtDanismanAd.Name = "txtDanismanAd";
            txtDanismanAd.Size = new Size(100, 23);
            txtDanismanAd.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 83);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 23;
            label8.Text = "Danisman Soyadi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(393, 36);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 22;
            label9.Text = "Danisman Adi";
            // 
            // BtnSil3
            // 
            BtnSil3.Location = new Point(810, 269);
            BtnSil3.Name = "BtnSil3";
            BtnSil3.Size = new Size(56, 23);
            BtnSil3.TabIndex = 28;
            BtnSil3.Tag = "OgrenciDelete";
            BtnSil3.Text = "Sil";
            BtnSil3.UseVisualStyleBackColor = true;
            BtnSil3.Click += BtnDelete;
            // 
            // BtnGunc3
            // 
            BtnGunc3.Location = new Point(729, 269);
            BtnGunc3.Name = "BtnGunc3";
            BtnGunc3.Size = new Size(56, 23);
            BtnGunc3.TabIndex = 27;
            BtnGunc3.Tag = "ogrenciGuncelle";
            BtnGunc3.Text = "Guncelle";
            BtnGunc3.UseVisualStyleBackColor = true;
            BtnGunc3.Click += btnUpdate;
            // 
            // BtnEkle3
            // 
            BtnEkle3.Location = new Point(652, 269);
            BtnEkle3.Name = "BtnEkle3";
            BtnEkle3.Size = new Size(56, 23);
            BtnEkle3.TabIndex = 26;
            BtnEkle3.Tag = "ogrenciEkle";
            BtnEkle3.Text = "Ekle";
            BtnEkle3.UseVisualStyleBackColor = true;
            BtnEkle3.Click += btnAdd;
            // 
            // dataGridDanisman
            // 
            dataGridDanisman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDanisman.Location = new Point(333, 318);
            dataGridDanisman.Name = "dataGridDanisman";
            dataGridDanisman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDanisman.Size = new Size(223, 223);
            dataGridDanisman.TabIndex = 29;
            dataGridDanisman.Tag = "DanismanData";
            dataGridDanisman.CellClick += dataGridDanisman_CellClick;
            // 
            // dataGridOgrenci
            // 
            dataGridOgrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOgrenci.Location = new Point(665, 318);
            dataGridOgrenci.Name = "dataGridOgrenci";
            dataGridOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOgrenci.Size = new Size(223, 223);
            dataGridOgrenci.TabIndex = 30;
            dataGridOgrenci.Tag = "DanismanData";
            // 
            // dersKodu
            // 
            dersKodu.Location = new Point(128, 623);
            dersKodu.Name = "dersKodu";
            dersKodu.Size = new Size(100, 23);
            dersKodu.TabIndex = 37;
            // 
            // dersAdi
            // 
            dersAdi.Location = new Point(128, 578);
            dersAdi.Name = "dersAdi";
            dersAdi.Size = new Size(100, 23);
            dersAdi.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 628);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 35;
            label10.Text = "Ders Kodu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 581);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 34;
            label11.Text = "Ders Adi";
            // 
            // button1
            // 
            button1.Location = new Point(187, 726);
            button1.Name = "button1";
            button1.Size = new Size(56, 23);
            button1.TabIndex = 33;
            button1.Tag = "dersSil";
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(106, 726);
            button2.Name = "button2";
            button2.Size = new Size(56, 23);
            button2.TabIndex = 32;
            button2.Tag = "dersGuncelle";
            button2.Text = "Guncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(29, 726);
            button3.Name = "button3";
            button3.Size = new Size(56, 23);
            button3.TabIndex = 31;
            button3.Tag = "dersEkle";
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAdd;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(128, 670);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(100, 23);
            txtKredi.TabIndex = 39;
            // 
            // dersKredi
            // 
            dersKredi.AutoSize = true;
            dersKredi.Location = new Point(24, 678);
            dersKredi.Name = "dersKredi";
            dersKredi.Size = new Size(60, 15);
            dersKredi.TabIndex = 38;
            dersKredi.Text = "Ders Kredi";
            // 
            // dataGridDers
            // 
            dataGridDers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDers.Location = new Point(333, 578);
            dataGridDers.Name = "dataGridDers";
            dataGridDers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDers.Size = new Size(223, 171);
            dataGridDers.TabIndex = 40;
            // 
            // comboOgreci2
            // 
            comboOgreci2.FormattingEnabled = true;
            comboOgreci2.Location = new Point(645, 598);
            comboOgreci2.Name = "comboOgreci2";
            comboOgreci2.Size = new Size(121, 23);
            comboOgreci2.TabIndex = 41;
            // 
            // comboDers2
            // 
            comboDers2.FormattingEnabled = true;
            comboDers2.Location = new Point(826, 598);
            comboDers2.Name = "comboDers2";
            comboDers2.Size = new Size(121, 23);
            comboDers2.TabIndex = 42;
            // 
            // button4
            // 
            button4.Location = new Point(773, 716);
            button4.Name = "button4";
            button4.Size = new Size(56, 23);
            button4.TabIndex = 43;
            button4.Tag = "ogrenciEkle";
            button4.Text = "Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(645, 580);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 44;
            label12.Text = "Ogrenci";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(917, 581);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 45;
            label13.Text = "Ders";
            // 
            // txtNot
            // 
            txtNot.Location = new Point(773, 648);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(100, 23);
            txtNot.TabIndex = 47;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(679, 651);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 46;
            label14.Text = "Not";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 779);
            Controls.Add(txtNot);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(button4);
            Controls.Add(comboDers2);
            Controls.Add(comboOgreci2);
            Controls.Add(dataGridDers);
            Controls.Add(txtKredi);
            Controls.Add(dersKredi);
            Controls.Add(dersKodu);
            Controls.Add(dersAdi);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dataGridOgrenci);
            Controls.Add(dataGridDanisman);
            Controls.Add(BtnSil3);
            Controls.Add(BtnGunc3);
            Controls.Add(BtnEkle3);
            Controls.Add(txtDanismanSoyad);
            Controls.Add(txtDanismanAd);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(cbOgrenciDiplama);
            Controls.Add(label7);
            Controls.Add(cbDanismanOgrenci);
            Controls.Add(label6);
            Controls.Add(BtnSil2);
            Controls.Add(btnGunc2);
            Controls.Add(btnEkle2);
            Controls.Add(dtOgrenciPiker);
            Controls.Add(txtOgrenciSoyad);
            Controls.Add(txtOgrenciAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtTimeTarih);
            Controls.Add(dataGridDiploamalar);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridDiploamalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDanisman).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOgrenci).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridDiploamalar;
        private DateTimePicker dtTimeTarih;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtOgrenciAd;
        private TextBox txtOgrenciSoyad;
        private DateTimePicker dtOgrenciPiker;
        private Button BtnSil2;
        private Button btnGunc2;
        private Button btnEkle2;
        private Label label6;
        private ComboBox cbDanismanOgrenci;
        private ComboBox cbOgrenciDiplama;
        private Label label7;
        private TextBox txtDanismanSoyad;
        private TextBox txtDanismanAd;
        private Label label8;
        private Label label9;
        private Button BtnSil3;
        private Button BtnGunc3;
        private Button BtnEkle3;
        private DataGridView dataGridDanisman;
        private DataGridView dataGridOgrenci;
        private TextBox dersKodu;
        private TextBox dersAdi;
        private Label label10;
        private Label label11;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtKredi;
        private Label dersKredi;
        private DataGridView dataGridDers;
        private ComboBox comboOgreci2;
        private ComboBox comboDers2;
        private Button button4;
        private Label label12;
        private Label label13;
        private TextBox txtNot;
        private Label label14;
    }
}
