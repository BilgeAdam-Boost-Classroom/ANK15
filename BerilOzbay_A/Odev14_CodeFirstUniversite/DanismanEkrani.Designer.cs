namespace CodeFirstUniversite
{
    partial class DanismanEkrani
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
            dgvDanismanlar = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanismanlar).BeginInit();
            SuspendLayout();
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(190, 107);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(204, 27);
            txtSoyadi.TabIndex = 11;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(190, 59);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(204, 27);
            txtAdi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 110);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 9;
            label2.Text = "Danisman Soyadi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 62);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 8;
            label1.Text = "Danisman Adi:";
            // 
            // dgvDanismanlar
            // 
            dgvDanismanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanismanlar.Location = new Point(464, 59);
            dgvDanismanlar.Name = "dgvDanismanlar";
            dgvDanismanlar.RowHeadersWidth = 51;
            dgvDanismanlar.RowTemplate.Height = 29;
            dgvDanismanlar.Size = new Size(444, 428);
            dgvDanismanlar.TabIndex = 12;
            dgvDanismanlar.CellClick += dgvDanismanlar_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(54, 173);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(169, 173);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(300, 173);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // DanismanEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 524);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvDanismanlar);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DanismanEkrani";
            Text = "DanismanEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvDanismanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label2;
        private Label label1;
        private DataGridView dgvDanismanlar;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}