namespace ArabamDb_codeFirst
{
    partial class PlakaFormu
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
            Ad = new Label();
            txtKodu = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvPlaka = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlaka).BeginInit();
            SuspendLayout();
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.Location = new Point(41, 36);
            Ad.Name = "Ad";
            Ad.Size = new Size(66, 15);
            Ad.TabIndex = 0;
            Ad.Text = "Plaka Kodu";
            // 
            // txtKodu
            // 
            txtKodu.Location = new Point(120, 33);
            txtKodu.Name = "txtKodu";
            txtKodu.Size = new Size(100, 23);
            txtKodu.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(29, 156);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(145, 156);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(256, 156);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dgvPlaka
            // 
            dgvPlaka.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaka.Location = new Point(488, 29);
            dgvPlaka.Name = "dgvPlaka";
            dgvPlaka.Size = new Size(240, 150);
            dgvPlaka.TabIndex = 7;
            // 
            // PlakaFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPlaka);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtKodu);
            Controls.Add(Ad);
            Name = "PlakaFormu";
            Text = "PlakaFormu";
            ((System.ComponentModel.ISupportInitialize)dgvPlaka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ad;
        private TextBox txtKodu;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvPlaka;
    }
}