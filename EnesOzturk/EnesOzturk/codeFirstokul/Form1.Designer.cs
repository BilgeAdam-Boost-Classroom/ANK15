namespace codeFirstokul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDiplomaNo = new Label();
            lblDiplomaTarih = new Label();
            txtDiplomaNo = new TextBox();
            txtDiplomaTarih = new TextBox();
            btnEkle = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            dgvDiplomalar = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiplomalar).BeginInit();
            SuspendLayout();
            // 
            // lblDiplomaNo
            // 
            lblDiplomaNo.AutoSize = true;
            lblDiplomaNo.Location = new Point(82, 77);
            lblDiplomaNo.Name = "lblDiplomaNo";
            lblDiplomaNo.Size = new Size(77, 15);
            lblDiplomaNo.TabIndex = 0;
            lblDiplomaNo.Text = "Diploma No :";
            // 
            // lblDiplomaTarih
            // 
            lblDiplomaTarih.AutoSize = true;
            lblDiplomaTarih.Location = new Point(82, 103);
            lblDiplomaTarih.Name = "lblDiplomaTarih";
            lblDiplomaTarih.Size = new Size(86, 15);
            lblDiplomaTarih.TabIndex = 2;
            lblDiplomaTarih.Text = "Diploma Tarih :";
            // 
            // txtDiplomaNo
            // 
            txtDiplomaNo.Location = new Point(191, 69);
            txtDiplomaNo.Name = "txtDiplomaNo";
            txtDiplomaNo.Size = new Size(156, 23);
            txtDiplomaNo.TabIndex = 3;
            // 
            // txtDiplomaTarih
            // 
            txtDiplomaTarih.Location = new Point(191, 95);
            txtDiplomaTarih.Name = "txtDiplomaTarih";
            txtDiplomaTarih.Size = new Size(156, 23);
            txtDiplomaTarih.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(110, 141);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(191, 141);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 6;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(272, 141);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvDiplomalar
            // 
            dgvDiplomalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiplomalar.Location = new Point(378, 38);
            dgvDiplomalar.Name = "dgvDiplomalar";
            dgvDiplomalar.Size = new Size(410, 222);
            dgvDiplomalar.TabIndex = 8;
            dgvDiplomalar.CellClick += dgvDiplomalar_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 184);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 9;
            label1.Text = "Seçilen Diploma :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvDiplomalar);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtDiplomaTarih);
            Controls.Add(txtDiplomaNo);
            Controls.Add(lblDiplomaTarih);
            Controls.Add(lblDiplomaNo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiplomalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiplomaNo;
        private Label lblDiplomaTarih;
        private TextBox txtDiplomaNo;
        private TextBox txtDiplomaTarih;
        private Button btnEkle;
        private Button btnGüncelle;
        private Button btnSil;
        private DataGridView dgvDiplomalar;
        private Label label1;
    }
}
