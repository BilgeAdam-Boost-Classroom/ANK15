namespace UniversiteCodeFirst
{
    partial class DanismanFormu
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvDanisman = new DataGridView();
            lblSecilenDanisman = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanisman).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(167, 25);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(167, 65);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(23, 129);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 45);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(128, 129);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 45);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(221, 129);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 45);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvDanisman
            // 
            dgvDanisman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanisman.Location = new Point(421, 25);
            dgvDanisman.Name = "dgvDanisman";
            dgvDanisman.Size = new Size(306, 190);
            dgvDanisman.TabIndex = 7;
            dgvDanisman.CellClick += dgvDanisman_CellClick;
            // 
            // lblSecilenDanisman
            // 
            lblSecilenDanisman.AutoSize = true;
            lblSecilenDanisman.Location = new Point(421, 246);
            lblSecilenDanisman.Name = "lblSecilenDanisman";
            lblSecilenDanisman.Size = new Size(0, 15);
            lblSecilenDanisman.TabIndex = 8;
            // 
            // DanismanFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSecilenDanisman);
            Controls.Add(dgvDanisman);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DanismanFormu";
            Text = "DanismanFormu";
            ((System.ComponentModel.ISupportInitialize)dgvDanisman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvDanisman;
        private Label lblSecilenDanisman;
    }
}