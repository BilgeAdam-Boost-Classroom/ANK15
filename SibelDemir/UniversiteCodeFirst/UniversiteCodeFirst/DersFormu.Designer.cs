namespace UniversiteCodeFirst
{
    partial class DersFormu
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
            txtKod = new TextBox();
            txtKredi = new TextBox();
            label3 = new Label();
            dgvDers = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 74);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Kod:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(124, 29);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 2;
            // 
            // txtKod
            // 
            txtKod.Location = new Point(124, 71);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(100, 23);
            txtKod.TabIndex = 3;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(124, 115);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(100, 23);
            txtKredi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 123);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Kredi:";
            // 
            // dgvDers
            // 
            dgvDers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDers.Location = new Point(450, 29);
            dgvDers.Name = "dgvDers";
            dgvDers.Size = new Size(305, 192);
            dgvDers.TabIndex = 6;
            dgvDers.CellClick += dgvDers_CellClick;
            dgvDers.CellContentClick += dgvDers_CellContentClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(38, 189);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 39);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(124, 189);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 39);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(217, 189);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 39);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // DersFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvDers);
            Controls.Add(label3);
            Controls.Add(txtKredi);
            Controls.Add(txtKod);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DersFormu";
            Text = "DersFormu";
            ((System.ComponentModel.ISupportInitialize)dgvDers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtKod;
        private TextBox txtKredi;
        private Label label3;
        private DataGridView dgvDers;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}