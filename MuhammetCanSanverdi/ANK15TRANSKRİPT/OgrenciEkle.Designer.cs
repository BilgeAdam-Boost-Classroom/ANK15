namespace ANK15TRANSKRİPT
{
    partial class OgrenciEkle
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
            txtbxAd = new TextBox();
            txtbxSoyad = new TextBox();
            txtbxNumara = new TextBox();
            btnEkle = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            dataGridViewOgrenci = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 72);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "Numara : ";
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(116, 27);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(150, 31);
            txtbxAd.TabIndex = 3;
            txtbxAd.TextChanged += textBox1_TextChanged;
            // 
            // txtbxSoyad
            // 
            txtbxSoyad.Location = new Point(116, 72);
            txtbxSoyad.Name = "txtbxSoyad";
            txtbxSoyad.Size = new Size(150, 31);
            txtbxSoyad.TabIndex = 4;
            // 
            // txtbxNumara
            // 
            txtbxNumara.Location = new Point(116, 115);
            txtbxNumara.Name = "txtbxNumara";
            txtbxNumara.Size = new Size(150, 31);
            txtbxNumara.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(61, 163);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(190, 163);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(112, 34);
            btnGüncelle.TabIndex = 7;
            btnGüncelle.Text = "GÜNCELLE";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(129, 215);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 8;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridViewOgrenci
            // 
            dataGridViewOgrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenci.Location = new Point(342, 27);
            dataGridViewOgrenci.Name = "dataGridViewOgrenci";
            dataGridViewOgrenci.RowHeadersWidth = 62;
            dataGridViewOgrenci.RowTemplate.Height = 33;
            dataGridViewOgrenci.Size = new Size(562, 422);
            dataGridViewOgrenci.TabIndex = 9;
            dataGridViewOgrenci.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 461);
            Controls.Add(dataGridViewOgrenci);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtbxNumara);
            Controls.Add(txtbxSoyad);
            Controls.Add(txtbxAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkle";
            Text = "OgrenciEkle";
            Load += OgrenciEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbxAd;
        private TextBox txtbxSoyad;
        private TextBox txtbxNumara;
        private Button btnEkle;
        private Button btnGüncelle;
        private Button btnSil;
        private DataGridView dataGridViewOgrenci;
    }
}
