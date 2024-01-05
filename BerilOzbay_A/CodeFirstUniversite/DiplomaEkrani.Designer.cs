namespace CodeFirstUniversite
{
    partial class DiplomaEkrani
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
            label1 = new Label();
            label2 = new Label();
            txtNo = new TextBox();
            txtTarih = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvDiplomalar = new DataGridView();
            lblSecilen = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiplomalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Diploma No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 93);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Diploma Tarih:";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(173, 42);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(204, 27);
            txtNo.TabIndex = 2;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(173, 90);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(204, 27);
            txtTarih.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(37, 138);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(155, 138);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(283, 138);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dgvDiplomalar
            // 
            dgvDiplomalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiplomalar.Location = new Point(37, 197);
            dgvDiplomalar.Name = "dgvDiplomalar";
            dgvDiplomalar.RowHeadersWidth = 51;
            dgvDiplomalar.RowTemplate.Height = 29;
            dgvDiplomalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiplomalar.Size = new Size(340, 303);
            dgvDiplomalar.TabIndex = 7;
            dgvDiplomalar.CellClick += dgvDiplomalar_CellClick;
            // 
            // lblSecilen
            // 
            lblSecilen.BorderStyle = BorderStyle.FixedSingle;
            lblSecilen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecilen.Location = new Point(37, 531);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(340, 70);
            lblSecilen.TabIndex = 8;
            lblSecilen.Text = "Seçilen Diploma:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 610);
            Controls.Add(lblSecilen);
            Controls.Add(dgvDiplomalar);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtTarih);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDiplomalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private TextBox txtTarih;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvDiplomalar;
        private Label lblSecilen;
    }
}