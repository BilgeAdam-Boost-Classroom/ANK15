
namespace UniversiteUygulama
{
    partial class OgrenciForm
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
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtbxSoyad = new TextBox();
            txtbxAd = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            cbxDanisman = new ComboBox();
            btnNewDiploma = new Button();
            label5 = new Label();
            txtbxNumara = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad : ";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 340);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 60);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(154, 340);
            btnGuncelle.Margin = new Padding(4, 5, 4, 5);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 60);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(289, 340);
            btnSil.Margin = new Padding(4, 5, 4, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 60);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtbxSoyad
            // 
            txtbxSoyad.Location = new Point(169, 113);
            txtbxSoyad.Margin = new Padding(4, 5, 4, 5);
            txtbxSoyad.Name = "txtbxSoyad";
            txtbxSoyad.Size = new Size(221, 31);
            txtbxSoyad.TabIndex = 6;
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(169, 62);
            txtbxAd.Margin = new Padding(4, 5, 4, 5);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(221, 31);
            txtbxAd.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(509, 50);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(571, 495);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowStateChanged += DataGridView1_RowStateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 9;
            label3.Text = "Danışman : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 267);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 10;
            label4.Text = "Diploma oluştur : ";
            // 
            // cbxDanisman
            // 
            cbxDanisman.FormattingEnabled = true;
            cbxDanisman.Location = new Point(169, 207);
            cbxDanisman.Name = "cbxDanisman";
            cbxDanisman.Size = new Size(221, 33);
            cbxDanisman.TabIndex = 11;
            // 
            // btnNewDiploma
            // 
            btnNewDiploma.Location = new Point(169, 263);
            btnNewDiploma.Name = "btnNewDiploma";
            btnNewDiploma.Size = new Size(166, 45);
            btnNewDiploma.TabIndex = 12;
            btnNewDiploma.Text = "Yeni Diploma";
            btnNewDiploma.UseVisualStyleBackColor = true;
            btnNewDiploma.Click += btnNewDiploma_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 160);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 13;
            label5.Text = "Numara : ";
            // 
            // txtbxNumara
            // 
            txtbxNumara.Location = new Point(169, 157);
            txtbxNumara.Margin = new Padding(4, 5, 4, 5);
            txtbxNumara.Name = "txtbxNumara";
            txtbxNumara.Size = new Size(221, 31);
            txtbxNumara.TabIndex = 14;
            // 
            // OgrenciForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtbxNumara);
            Controls.Add(label5);
            Controls.Add(btnNewDiploma);
            Controls.Add(cbxDanisman);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtbxAd);
            Controls.Add(txtbxSoyad);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OgrenciForm";
            Text = "OgrenciForm";
            Load += OgrenciForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtbxSoyad;
        private TextBox txtbxAd;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private ComboBox cbxDanisman;
        private Button btnNewDiploma;

        #endregion

        private Label label5;
        private TextBox txtbxNumara;
    }
}