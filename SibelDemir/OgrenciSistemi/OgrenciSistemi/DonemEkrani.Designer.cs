namespace OgrenciSistemi
{
    partial class DonemEkrani
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
            txtNo = new TextBox();
            txtAd = new TextBox();
            btnEKLE = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 1;
            label2.Text = "No:";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(203, 111);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(150, 31);
            txtNo.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(203, 44);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 31);
            txtAd.TabIndex = 3;
            // 
            // btnEKLE
            // 
            btnEKLE.Location = new Point(77, 241);
            btnEKLE.Name = "btnEKLE";
            btnEKLE.Size = new Size(112, 34);
            btnEKLE.TabIndex = 5;
            btnEKLE.Text = "EKLE";
            btnEKLE.UseVisualStyleBackColor = true;
            btnEKLE.Click += btnEKLE_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(259, 241);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(112, 34);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(177, 318);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 7;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(451, 479);
            dataGridView1.TabIndex = 8;
            // 
            // DonemEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 573);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEKLE);
            Controls.Add(txtAd);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DonemEkrani";
            Text = "DönemEkrani";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private TextBox txtAd;
        private Button btnEKLE;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridView1;
    }
}