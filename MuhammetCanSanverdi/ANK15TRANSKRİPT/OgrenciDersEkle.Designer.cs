namespace ANK15TRANSKRİPT
{
    partial class OgrenciDersEkle
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
            cbxOgrenci = new ComboBox();
            cbxDers = new ComboBox();
            label2 = new Label();
            cbxHarfNotu = new ComboBox();
            label3 = new Label();
            cbxDonem = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnDersEkle = new Button();
            btnDersCikar = new Button();
            btnTranskripGor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci :";
            // 
            // cbxOgrenci
            // 
            cbxOgrenci.FormattingEnabled = true;
            cbxOgrenci.Location = new Point(115, 30);
            cbxOgrenci.Name = "cbxOgrenci";
            cbxOgrenci.Size = new Size(182, 33);
            cbxOgrenci.TabIndex = 1;
            // 
            // cbxDers
            // 
            cbxDers.FormattingEnabled = true;
            cbxDers.Location = new Point(380, 30);
            cbxDers.Name = "cbxDers";
            cbxDers.Size = new Size(182, 33);
            cbxDers.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 30);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Ders :";
            // 
            // cbxHarfNotu
            // 
            cbxHarfNotu.FormattingEnabled = true;
            cbxHarfNotu.Location = new Point(986, 30);
            cbxHarfNotu.Name = "cbxHarfNotu";
            cbxHarfNotu.Size = new Size(182, 33);
            cbxHarfNotu.TabIndex = 7;
            cbxHarfNotu.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(875, 30);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 6;
            label3.Text = "Harf Notu : ";
            // 
            // cbxDonem
            // 
            cbxDonem.FormattingEnabled = true;
            cbxDonem.Location = new Point(673, 30);
            cbxDonem.Name = "cbxDonem";
            cbxDonem.Size = new Size(182, 33);
            cbxDonem.TabIndex = 5;
            cbxDonem.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 33);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 4;
            label4.Text = "Dönem :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1142, 322);
            dataGridView1.TabIndex = 8;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDersEkle.Location = new Point(26, 456);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(281, 75);
            btnDersEkle.TabIndex = 11;
            btnDersEkle.Text = "Öğrenci Ders Ekle";
            btnDersEkle.UseVisualStyleBackColor = true;
            // 
            // btnDersCikar
            // 
            btnDersCikar.Location = new Point(432, 456);
            btnDersCikar.Name = "btnDersCikar";
            btnDersCikar.Size = new Size(321, 75);
            btnDersCikar.TabIndex = 12;
            btnDersCikar.Text = "Öğrenci Ders Çıkar";
            btnDersCikar.UseVisualStyleBackColor = true;
            // 
            // btnTranskripGor
            // 
            btnTranskripGor.Location = new Point(875, 456);
            btnTranskripGor.Name = "btnTranskripGor";
            btnTranskripGor.Size = new Size(293, 75);
            btnTranskripGor.TabIndex = 13;
            btnTranskripGor.Text = "Transkript Gör";
            btnTranskripGor.UseVisualStyleBackColor = true;
            // 
            // OgrenciDersEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 572);
            Controls.Add(btnTranskripGor);
            Controls.Add(btnDersCikar);
            Controls.Add(btnDersEkle);
            Controls.Add(dataGridView1);
            Controls.Add(cbxHarfNotu);
            Controls.Add(label3);
            Controls.Add(cbxDonem);
            Controls.Add(label4);
            Controls.Add(cbxDers);
            Controls.Add(label2);
            Controls.Add(cbxOgrenci);
            Controls.Add(label1);
            Name = "OgrenciDersEkle";
            Text = "OgrenciDersEkle";
            Load += OgrenciDersEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDers;
        private Label label2;
        private ComboBox cbxHarfNotu;
        private Label label3;
        private ComboBox cbxDonem;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnDersEkle;
        private Button btnDersCikar;
        private Button btnTranskripGor;
    }
}