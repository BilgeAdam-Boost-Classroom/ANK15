namespace UniversiteDBFirst
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
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNumara = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(684, 481);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(274, 273);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(164, 273);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(53, 273);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(162, 153);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(180, 27);
            txtSoyadi.TabIndex = 11;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(162, 106);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(180, 27);
            txtAdi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 149);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 9;
            label2.Text = "Soyadi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 106);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 8;
            label1.Text = "Adi:";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(162, 201);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(180, 27);
            txtNumara.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 197);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 16;
            label3.Text = "Numara:";
            // 
            // Ogrenci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 598);
            Controls.Add(txtNumara);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ogrenci";
            Text = "Ogrenci";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label2;
        private Label label1;
        private TextBox txtNumara;
        private Label label3;
    }
}