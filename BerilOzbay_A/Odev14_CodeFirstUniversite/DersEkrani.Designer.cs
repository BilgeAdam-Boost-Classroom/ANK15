namespace CodeFirstUniversite
{
    partial class DersEkrani
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
            txtKodu = new TextBox();
            txtAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtKredi = new TextBox();
            label3 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvDersler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // txtKodu
            // 
            txtKodu.Location = new Point(187, 105);
            txtKodu.Name = "txtKodu";
            txtKodu.Size = new Size(204, 27);
            txtKodu.TabIndex = 15;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(187, 57);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(204, 27);
            txtAdi.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 108);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 13;
            label2.Text = "Ders Kodu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 60);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 12;
            label1.Text = "Ders Adi:";
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(187, 153);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(204, 27);
            txtKredi.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 156);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 16;
            label3.Text = "Ders Kredisi:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(51, 228);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(175, 228);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 19;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(297, 228);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 20;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvDersler
            // 
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(481, 57);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.RowHeadersWidth = 51;
            dgvDersler.RowTemplate.Height = 29;
            dgvDersler.Size = new Size(487, 395);
            dgvDersler.TabIndex = 21;
            dgvDersler.CellClick += dgvDersler_CellClick;
            // 
            // DersEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 517);
            Controls.Add(dgvDersler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtKredi);
            Controls.Add(label3);
            Controls.Add(txtKodu);
            Controls.Add(txtAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DersEkrani";
            Text = "DersEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKodu;
        private TextBox txtAdi;
        private Label label2;
        private Label label1;
        private TextBox txtKredi;
        private Label label3;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvDersler;
    }
}