namespace BankaUygulamasi
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
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            dataGridView1 = new DataGridView();
            btnSiradaki = new Button();
            label3 = new Label();
            lblSiradaki = new Label();
            label4 = new Label();
            cmbMusteriTurleri = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(36, 162);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(225, 46);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 78);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "T.C:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(136, 40);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(143, 27);
            txtAdSoyad.TabIndex = 3;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(136, 78);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(143, 27);
            txtTc.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 282);
            dataGridView1.TabIndex = 5;
            // 
            // btnSiradaki
            // 
            btnSiradaki.Location = new Point(36, 229);
            btnSiradaki.Name = "btnSiradaki";
            btnSiradaki.Size = new Size(225, 46);
            btnSiradaki.TabIndex = 6;
            btnSiradaki.Text = "Siradakini Sec";
            btnSiradaki.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 342);
            label3.Name = "label3";
            label3.Size = new Size(193, 41);
            label3.TabIndex = 7;
            label3.Text = "İslemdeki Musteri";
            // 
            // lblSiradaki
            // 
            lblSiradaki.BorderStyle = BorderStyle.FixedSingle;
            lblSiradaki.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiradaki.Location = new Point(225, 342);
            lblSiradaki.Name = "lblSiradaki";
            lblSiradaki.Size = new Size(540, 41);
            lblSiradaki.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 114);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 9;
            label4.Text = "Musteri Turu:";
            // 
            // cmbMusteriTurleri
            // 
            cmbMusteriTurleri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteriTurleri.FormattingEnabled = true;
            cmbMusteriTurleri.Location = new Point(136, 114);
            cmbMusteriTurleri.Name = "cmbMusteriTurleri";
            cmbMusteriTurleri.Size = new Size(151, 28);
            cmbMusteriTurleri.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMusteriTurleri);
            Controls.Add(label4);
            Controls.Add(lblSiradaki);
            Controls.Add(label3);
            Controls.Add(btnSiradaki);
            Controls.Add(dataGridView1);
            Controls.Add(txtTc);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private DataGridView dataGridView1;
        private Button btnSiradaki;
        private Label label3;
        private Label lblSiradaki;
        private Label label4;
        private ComboBox cmbMusteriTurleri;
    }
}