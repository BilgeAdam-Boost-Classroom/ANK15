namespace Ank15BankaUygulamasi
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
            TxtTC = new TextBox();
            BtnEkle = new Button();
            DvgMusteriler = new DataGridView();
            btnSiradaki = new Button();
            LblIslemdeki = new Label();
            lblSiradaki = new Label();
            label3 = new Label();
            cmbMusteriTurleri = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DvgMusteriler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 95);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Tc :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(112, 50);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(121, 23);
            txtAdSoyad.TabIndex = 2;
            // 
            // TxtTC
            // 
            TxtTC.Location = new Point(112, 87);
            TxtTC.Name = "TxtTC";
            TxtTC.Size = new Size(121, 23);
            TxtTC.TabIndex = 3;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(112, 179);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(121, 23);
            BtnEkle.TabIndex = 4;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // DvgMusteriler
            // 
            DvgMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvgMusteriler.Location = new Point(440, 50);
            DvgMusteriler.Name = "DvgMusteriler";
            DvgMusteriler.RowTemplate.Height = 25;
            DvgMusteriler.Size = new Size(323, 359);
            DvgMusteriler.TabIndex = 5;
            // 
            // btnSiradaki
            // 
            btnSiradaki.Location = new Point(58, 372);
            btnSiradaki.Name = "btnSiradaki";
            btnSiradaki.Size = new Size(298, 23);
            btnSiradaki.TabIndex = 6;
            btnSiradaki.Text = "Siradaki";
            btnSiradaki.UseVisualStyleBackColor = true;
            btnSiradaki.Click += btnSiradaki_Click;
            // 
            // LblIslemdeki
            // 
            LblIslemdeki.Font = new Font("Roboto Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblIslemdeki.Location = new Point(12, 422);
            LblIslemdeki.Name = "LblIslemdeki";
            LblIslemdeki.Size = new Size(192, 23);
            LblIslemdeki.TabIndex = 7;
            LblIslemdeki.Text = "Islemdeki Musteri";
            // 
            // lblSiradaki
            // 
            lblSiradaki.BorderStyle = BorderStyle.FixedSingle;
            lblSiradaki.Location = new Point(218, 422);
            lblSiradaki.Name = "lblSiradaki";
            lblSiradaki.Size = new Size(545, 23);
            lblSiradaki.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 9;
            label3.Text = "Musteri Turu :";
            // 
            // cmbMusteriTurleri
            // 
            cmbMusteriTurleri.FormattingEnabled = true;
            cmbMusteriTurleri.Location = new Point(112, 126);
            cmbMusteriTurleri.Name = "cmbMusteriTurleri";
            cmbMusteriTurleri.Size = new Size(121, 23);
            cmbMusteriTurleri.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMusteriTurleri);
            Controls.Add(label3);
            Controls.Add(lblSiradaki);
            Controls.Add(LblIslemdeki);
            Controls.Add(btnSiradaki);
            Controls.Add(DvgMusteriler);
            Controls.Add(BtnEkle);
            Controls.Add(TxtTC);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DvgMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox TxtTC;
        private Button BtnEkle;
        private DataGridView DvgMusteriler;
        private Button btnSiradaki;
        private Label LblIslemdeki;
        private Label lblSiradaki;
        private Label label3;
        private ComboBox cmbMusteriTurleri;
    }
}