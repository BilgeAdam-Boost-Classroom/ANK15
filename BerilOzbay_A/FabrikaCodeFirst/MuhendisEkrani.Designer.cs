namespace FabrikaCodeFirst
{
    partial class MuhendisEkrani
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
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvMuhendisler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMuhendisler).BeginInit();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(183, 130);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(214, 27);
            txtSoyad.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 130);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 8;
            label2.Text = "Muhendis Soyadi:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(183, 72);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(214, 27);
            txtAd.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 72);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 6;
            label1.Text = "Muhendis Adi:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(52, 197);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(183, 197);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(303, 197);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvMuhendisler
            // 
            dgvMuhendisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuhendisler.Location = new Point(451, 72);
            dgvMuhendisler.Name = "dgvMuhendisler";
            dgvMuhendisler.RowHeadersWidth = 51;
            dgvMuhendisler.RowTemplate.Height = 29;
            dgvMuhendisler.Size = new Size(410, 428);
            dgvMuhendisler.TabIndex = 13;
            dgvMuhendisler.CellClick += dgvMuhendisler_CellClick;
            // 
            // MuhendisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 535);
            Controls.Add(dgvMuhendisler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "MuhendisEkrani";
            Text = "MuhendisEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvMuhendisler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvMuhendisler;
    }
}