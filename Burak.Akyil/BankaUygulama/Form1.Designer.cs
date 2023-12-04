namespace BankaUygulama
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
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtTcNo = new TextBox();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            dgvMusteriler = new DataGridView();
            btnSiradaki = new Button();
            label3 = new Label();
            lblSiradaki = new Label();
            label5 = new Label();
            cmbMusteriTurleri = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 66);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 0;
            label2.Text = "T.C:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(120, 34);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(120, 63);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(100, 23);
            txtTcNo.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(249, 34);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 52);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(440, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(327, 354);
            dataGridView1.TabIndex = 3;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(440, 34);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowTemplate.Height = 25;
            dgvMusteriler.Size = new Size(327, 354);
            dgvMusteriler.TabIndex = 3;
            // 
            // btnSiradaki
            // 
            btnSiradaki.Location = new Point(120, 153);
            btnSiradaki.Name = "btnSiradaki";
            btnSiradaki.Size = new Size(167, 120);
            btnSiradaki.TabIndex = 2;
            btnSiradaki.Text = "SIRADAKİ";
            btnSiradaki.UseVisualStyleBackColor = true;
            btnSiradaki.Click += btnSiradaki_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 399);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 0;
            label3.Text = "İşlemdeki Müşteri:";
            // 
            // lblSiradaki
            // 
            lblSiradaki.BorderStyle = BorderStyle.FixedSingle;
            lblSiradaki.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiradaki.Location = new Point(168, 399);
            lblSiradaki.Name = "lblSiradaki";
            lblSiradaki.Size = new Size(484, 24);
            lblSiradaki.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 97);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 5;
            label5.Text = "Müşteri Türü:";
            // 
            // cmbMusteriTurleri
            // 
            cmbMusteriTurleri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteriTurleri.FormattingEnabled = true;
            cmbMusteriTurleri.Location = new Point(120, 92);
            cmbMusteriTurleri.Name = "cmbMusteriTurleri";
            cmbMusteriTurleri.Size = new Size(100, 23);
            cmbMusteriTurleri.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMusteriTurleri);
            Controls.Add(label5);
            Controls.Add(lblSiradaki);
            Controls.Add(dgvMusteriler);
            Controls.Add(btnSiradaki);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtTcNo);
            Controls.Add(txtAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtTcNo;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private DataGridView dgvMusteriler;
        private Button btnSiradaki;
        private Label label3;
        private Label lblSiradaki;
        private Label label5;
        private ComboBox cmbMusteriTurleri;
    }
}