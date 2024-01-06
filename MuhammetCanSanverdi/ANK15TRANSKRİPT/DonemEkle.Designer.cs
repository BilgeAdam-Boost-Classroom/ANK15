namespace ANK15TRANSKRİPT
{
    partial class DonemEkle
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
            txtbxNo = new TextBox();
            txtbxAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(562, 422);
            dataGridView1.TabIndex = 29;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(100, 185);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 28;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(161, 133);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(112, 34);
            btnGüncelle.TabIndex = 27;
            btnGüncelle.Text = "GÜNCELLE";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(32, 133);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 26;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtbxNo
            // 
            txtbxNo.Location = new Point(87, 83);
            txtbxNo.Name = "txtbxNo";
            txtbxNo.Size = new Size(150, 31);
            txtbxNo.TabIndex = 24;
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(87, 38);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(150, 31);
            txtbxAd.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 21;
            label2.Text = "No : ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 20;
            label1.Text = "Ad : ";
            // 
            // DonemEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 504);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtbxNo);
            Controls.Add(txtbxAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DonemEkle";
            Text = "DonemEkle";
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
        private TextBox txtbxNo;
        private TextBox txtbxAd;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}