namespace FabrikaCodeFirst
{
    partial class KisiEkrani
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
            txtAd = new TextBox();
            label1 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvKisiler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(180, 80);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(214, 27);
            txtAd.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 80);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Kisi Adi:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(180, 138);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(214, 27);
            txtSoyad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 138);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Kisi Soyadi:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(76, 201);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(198, 201);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(327, 201);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvKisiler
            // 
            dgvKisiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisiler.Location = new Point(472, 52);
            dgvKisiler.Name = "dgvKisiler";
            dgvKisiler.RowHeadersWidth = 51;
            dgvKisiler.RowTemplate.Height = 29;
            dgvKisiler.Size = new Size(420, 417);
            dgvKisiler.TabIndex = 9;
            dgvKisiler.CellClick += dgvKisiler_CellClick;
            // 
            // KisiEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 538);
            Controls.Add(dgvKisiler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "KisiEkrani";
            Text = "KisiEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label1;
        private TextBox txtSoyad;
        private Label label2;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvKisiler;
    }
}