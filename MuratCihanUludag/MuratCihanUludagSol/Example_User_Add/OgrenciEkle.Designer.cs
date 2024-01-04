namespace Example_User_Add
{
    partial class OgrenciEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonEkle = new Button();
            buttonGunc = new Button();
            buttonSil = new Button();
            dataGridV2 = new DataGridView();
            label4 = new Label();
            comboBoxOgr = new ComboBox();
            comboBoxDnm = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            dnmGet = new Label();
            label7 = new Label();
            comboBoxDiploama = new ComboBox();
            label8 = new Label();
            textBoxNo = new TextBox();
            label9 = new Label();
            textBoxDate = new TextBox();
            label10 = new Label();
            btnEkle2 = new Button();
            dataGridV3 = new DataGridView();
            btnGunc2 = new Button();
            btnSil2 = new Button();
            label11 = new Label();
            dataGridV4 = new DataGridView();
            textBoxDersKredi = new TextBox();
            textBoxDersKod = new TextBox();
            textBoxDersAd = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridV3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridV4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 55);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 103);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 156);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Numara";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(59, 264);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(100, 23);
            buttonEkle.TabIndex = 6;
            buttonEkle.Tag = "OgrenciEkle";
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += Add;
            // 
            // buttonGunc
            // 
            buttonGunc.Location = new Point(206, 264);
            buttonGunc.Name = "buttonGunc";
            buttonGunc.Size = new Size(75, 23);
            buttonGunc.TabIndex = 7;
            buttonGunc.Text = "Guncelle";
            buttonGunc.UseVisualStyleBackColor = true;
            buttonGunc.Click += Update;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(358, 264);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(75, 23);
            buttonSil.TabIndex = 8;
            buttonSil.Tag = "OgrenciSil";
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += Delete;
            // 
            // dataGridV2
            // 
            dataGridV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridV2.Location = new Point(421, 55);
            dataGridV2.Name = "dataGridV2";
            dataGridV2.Size = new Size(313, 150);
            dataGridV2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 307);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 10;
            label4.Text = "Danisman ata";
            // 
            // comboBoxOgr
            // 
            comboBoxOgr.FormattingEnabled = true;
            comboBoxOgr.Location = new Point(59, 343);
            comboBoxOgr.Name = "comboBoxOgr";
            comboBoxOgr.Size = new Size(121, 23);
            comboBoxOgr.TabIndex = 11;
            // 
            // comboBoxDnm
            // 
            comboBoxDnm.FormattingEnabled = true;
            comboBoxDnm.Location = new Point(312, 343);
            comboBoxDnm.Name = "comboBoxDnm";
            comboBoxDnm.Size = new Size(121, 23);
            comboBoxDnm.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(206, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Ata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 325);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 14;
            label5.Text = "Ogrenci";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 325);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 15;
            label6.Text = "Danisman";
            // 
            // dnmGet
            // 
            dnmGet.AutoSize = true;
            dnmGet.Location = new Point(12, 391);
            dnmGet.Name = "dnmGet";
            dnmGet.Size = new Size(63, 15);
            dnmGet.TabIndex = 16;
            dnmGet.Text = "Danismani";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 204);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 17;
            label7.Text = "Diploma ";
            // 
            // comboBoxDiploama
            // 
            comboBoxDiploama.FormattingEnabled = true;
            comboBoxDiploama.Location = new Point(193, 201);
            comboBoxDiploama.Name = "comboBoxDiploama";
            comboBoxDiploama.Size = new Size(121, 23);
            comboBoxDiploama.TabIndex = 18;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.IpAddress;
            label8.AutoSize = true;
            label8.Location = new Point(555, 268);
            label8.Name = "label8";
            label8.Size = new Size(140, 15);
            label8.TabIndex = 19;
            label8.Text = "Diploma Ekle Sil Guncelle";
            // 
            // textBoxNo
            // 
            textBoxNo.Location = new Point(580, 307);
            textBoxNo.Name = "textBoxNo";
            textBoxNo.Size = new Size(100, 23);
            textBoxNo.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 307);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 20;
            label9.Text = "No";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(580, 343);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(100, 23);
            textBoxDate.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 343);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 22;
            label10.Text = "Tarih";
            // 
            // btnEkle2
            // 
            btnEkle2.Location = new Point(488, 395);
            btnEkle2.Name = "btnEkle2";
            btnEkle2.Size = new Size(75, 23);
            btnEkle2.TabIndex = 24;
            btnEkle2.Tag = "DiplomaEkle";
            btnEkle2.Text = "Ekle";
            btnEkle2.UseVisualStyleBackColor = true;
            btnEkle2.Click += Add;
            // 
            // dataGridV3
            // 
            dataGridV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridV3.Location = new Point(803, 268);
            dataGridV3.Name = "dataGridV3";
            dataGridV3.Size = new Size(258, 150);
            dataGridV3.TabIndex = 25;
            // 
            // btnGunc2
            // 
            btnGunc2.Location = new Point(591, 395);
            btnGunc2.Name = "btnGunc2";
            btnGunc2.Size = new Size(75, 23);
            btnGunc2.TabIndex = 26;
            btnGunc2.Text = "Guncelle";
            btnGunc2.UseVisualStyleBackColor = true;
            btnGunc2.Click += Update;
            // 
            // btnSil2
            // 
            btnSil2.Location = new Point(686, 395);
            btnSil2.Name = "btnSil2";
            btnSil2.Size = new Size(75, 23);
            btnSil2.TabIndex = 27;
            btnSil2.Tag = "DiplomaSil";
            btnSil2.Text = "Sil";
            btnSil2.UseVisualStyleBackColor = true;
            btnSil2.Click += Delete;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(45, 511);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 28;
            label11.Text = "Ders";
            // 
            // dataGridV4
            // 
            dataGridV4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridV4.Location = new Point(421, 538);
            dataGridV4.Name = "dataGridV4";
            dataGridV4.Size = new Size(313, 207);
            dataGridV4.TabIndex = 29;
            // 
            // textBoxDersKredi
            // 
            textBoxDersKredi.Location = new Point(206, 656);
            textBoxDersKredi.Name = "textBoxDersKredi";
            textBoxDersKredi.Size = new Size(100, 23);
            textBoxDersKredi.TabIndex = 35;
            // 
            // textBoxDersKod
            // 
            textBoxDersKod.Location = new Point(206, 606);
            textBoxDersKod.Name = "textBoxDersKod";
            textBoxDersKod.Size = new Size(100, 23);
            textBoxDersKod.TabIndex = 34;
            // 
            // textBoxDersAd
            // 
            textBoxDersAd.Location = new Point(206, 558);
            textBoxDersAd.Name = "textBoxDersAd";
            textBoxDersAd.Size = new Size(100, 23);
            textBoxDersAd.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(125, 659);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 32;
            label12.Text = "Kredi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(125, 606);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 31;
            label13.Text = "Kod";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(125, 558);
            label14.Name = "label14";
            label14.Size = new Size(22, 15);
            label14.TabIndex = 30;
            label14.Text = "Ad";
            // 
            // button2
            // 
            button2.Location = new Point(332, 712);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 38;
            button2.Tag = "DersSil";
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete;
            // 
            // button3
            // 
            button3.Location = new Point(180, 712);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 37;
            button3.Tag = "DersGuncelle";
            button3.Text = "Guncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Update;
            // 
            // button4
            // 
            button4.Location = new Point(33, 712);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 36;
            button4.Tag = "DersEkle";
            button4.Text = "Ders Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Add;
            // 
            // OgrenciEkle
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 747);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBoxDersKredi);
            Controls.Add(textBoxDersKod);
            Controls.Add(textBoxDersAd);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(dataGridV4);
            Controls.Add(label11);
            Controls.Add(btnSil2);
            Controls.Add(btnGunc2);
            Controls.Add(dataGridV3);
            Controls.Add(btnEkle2);
            Controls.Add(textBoxDate);
            Controls.Add(label10);
            Controls.Add(textBoxNo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBoxDiploama);
            Controls.Add(label7);
            Controls.Add(dnmGet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBoxDnm);
            Controls.Add(comboBoxOgr);
            Controls.Add(label4);
            Controls.Add(dataGridV2);
            Controls.Add(buttonSil);
            Controls.Add(buttonGunc);
            Controls.Add(buttonEkle);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkle";
            Text = "OgrenciEkle";
            ((System.ComponentModel.ISupportInitialize)dataGridV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridV3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridV4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonEkle;
        private Button buttonGunc;
        private Button buttonSil;
        private DataGridView dataGridV2;
        private Label label4;
        private ComboBox comboBoxOgr;
        private ComboBox comboBoxDnm;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label dnmGet;
        private Label label7;
        private ComboBox comboBoxDiploama;
        private Label label8;
        private TextBox textBoxNo;
        private Label label9;
        private TextBox textBoxDate;
        private Label label10;
        private Button btnEkle2;
        private DataGridView dataGridV3;
        private Button btnGunc2;
        private Button btnSil2;
        private Label label11;
        private DataGridView dataGridV4;
        private TextBox textBoxDersKredi;
        private TextBox textBoxDersKod;
        private TextBox textBoxDersAd;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}