namespace OkulExerciseWF
{
    partial class DanismanForm
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
            txtbxAd = new TextBox();
            txtbxSoyad = new TextBox();
            btnEkle = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad : ";
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(106, 33);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(205, 31);
            txtbxAd.TabIndex = 2;
            // 
            // txtbxSoyad
            // 
            txtbxSoyad.Location = new Point(106, 71);
            txtbxSoyad.Name = "txtbxSoyad";
            txtbxSoyad.Size = new Size(205, 31);
            txtbxSoyad.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(3, 135);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(121, 135);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(112, 34);
            btnGüncelle.TabIndex = 5;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(239, 135);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(406, 383);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtbxSoyad);
            Controls.Add(txtbxAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbxAd;
        private TextBox txtbxSoyad;
        private Button btnEkle;
        private Button btnGüncelle;
        private Button btnSil;
        private DataGridView dataGridView1;
    }
}
