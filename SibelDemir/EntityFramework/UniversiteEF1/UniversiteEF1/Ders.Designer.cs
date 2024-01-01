namespace UniversiteEF1
{
    partial class Ders
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
            label3 = new Label();
            txtAd = new TextBox();
            txtKod = new TextBox();
            txtKredi = new TextBox();
            dGWDers = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGWDers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 46);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Kod:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Kredi:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(54, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            // 
            // txtKod
            // 
            txtKod.Location = new Point(54, 43);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(100, 23);
            txtKod.TabIndex = 4;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(54, 74);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(100, 23);
            txtKredi.TabIndex = 5;
            // 
            // dGWDers
            // 
            dGWDers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWDers.Location = new Point(160, 12);
            dGWDers.Name = "dGWDers";
            dGWDers.Size = new Size(771, 235);
            dGWDers.TabIndex = 6;
            dGWDers.CellClick += dGWDers_CellClick;
            dGWDers.CellContentClick += dGWDers_CellContentClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(54, 103);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 44);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(54, 153);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 44);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(54, 203);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 44);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 259);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // Ders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 291);
            Controls.Add(label4);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dGWDers);
            Controls.Add(txtKredi);
            Controls.Add(txtKod);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ders";
            Text = "Ders";
            ((System.ComponentModel.ISupportInitialize)dGWDers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtKod;
        private TextBox txtKredi;
        private DataGridView dGWDers;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label4;
    }
}