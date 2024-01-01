namespace UniversiteEF1
{
    partial class Diploma
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
            dGWDiploma = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtNo = new TextBox();
            lblsecilenDiploma = new Label();
            lblTarih = new Label();
            lblNo = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dGWDiploma).BeginInit();
            SuspendLayout();
            // 
            // dGWDiploma
            // 
            dGWDiploma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWDiploma.Location = new Point(146, 24);
            dGWDiploma.Name = "dGWDiploma";
            dGWDiploma.Size = new Size(698, 139);
            dGWDiploma.TabIndex = 19;
            dGWDiploma.CellClick += dGWDiploma_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(65, 140);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 18;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(65, 111);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 17;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(65, 82);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(65, 24);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(75, 23);
            txtNo.TabIndex = 14;
            // 
            // lblsecilenDiploma
            // 
            lblsecilenDiploma.AutoSize = true;
            lblsecilenDiploma.Location = new Point(146, 166);
            lblsecilenDiploma.Name = "lblsecilenDiploma";
            lblsecilenDiploma.Size = new Size(95, 15);
            lblsecilenDiploma.TabIndex = 13;
            lblsecilenDiploma.Text = "Seçilen Diploma:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(12, 59);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(32, 15);
            lblTarih.TabIndex = 12;
            lblTarih.Text = "Tarih";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(12, 27);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(23, 15);
            lblNo.TabIndex = 11;
            lblNo.Text = "No";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(65, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(75, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // Diploma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 209);
            Controls.Add(dateTimePicker1);
            Controls.Add(dGWDiploma);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtNo);
            Controls.Add(lblsecilenDiploma);
            Controls.Add(lblTarih);
            Controls.Add(lblNo);
            Name = "Diploma";
            Text = "Diploma";
            ((System.ComponentModel.ISupportInitialize)dGWDiploma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumara;
        private Label label1;
        private DataGridView dGWDiploma;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtSoyad;
        private TextBox txtNo;
        private Label lblsecilenDiploma;
        private Label lblTarih;
        private Label lblNo;
        private DateTimePicker dateTimePicker1;
    }
}