namespace ANK15TRANSKRİPT
{
    partial class DersEkle
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
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnEkle = new Button();
            txtbxKredi = new TextBox();
            txtbxKod = new TextBox();
            txtbxAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(326, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(562, 422);
            dataGridView1.TabIndex = 19;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(123, 268);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 18;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(184, 216);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(112, 34);
            btnGüncelle.TabIndex = 17;
            btnGüncelle.Text = "GÜNCELLE";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(55, 216);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtbxKredi
            // 
            txtbxKredi.Location = new Point(110, 168);
            txtbxKredi.Name = "txtbxKredi";
            txtbxKredi.Size = new Size(150, 31);
            txtbxKredi.TabIndex = 15;
            // 
            // txtbxKod
            // 
            txtbxKod.Location = new Point(110, 125);
            txtbxKod.Name = "txtbxKod";
            txtbxKod.Size = new Size(150, 31);
            txtbxKod.TabIndex = 14;
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(110, 80);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(150, 31);
            txtbxAd.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 168);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 12;
            label3.Text = "Kredisi : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 128);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 11;
            label2.Text = "Kod : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 86);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 10;
            label1.Text = "Ad : ";
            // 
            // DersEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 533);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtbxKredi);
            Controls.Add(txtbxKod);
            Controls.Add(txtbxAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DersEkle";
            Text = "DersEkle";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnEkle;
        private TextBox txtbxKredi;
        private TextBox txtbxKod;
        private TextBox txtbxAd;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}