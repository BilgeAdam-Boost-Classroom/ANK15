namespace OkulExerciseWF
{
    partial class DersForm
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
            txtbxKod = new TextBox();
            txtbxAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtbxKredi = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(498, 474);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(260, 164);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(109, 33);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(142, 164);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(109, 33);
            btnGüncelle.TabIndex = 13;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(24, 164);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(109, 33);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtbxKod
            // 
            txtbxKod.Location = new Point(120, 74);
            txtbxKod.Name = "txtbxKod";
            txtbxKod.Size = new Size(202, 31);
            txtbxKod.TabIndex = 11;
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(120, 36);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(202, 31);
            txtbxAd.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 9;
            label2.Text = "Kod : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 8;
            label1.Text = "Ad : ";
            // 
            // txtbxKredi
            // 
            txtbxKredi.Location = new Point(120, 111);
            txtbxKredi.Name = "txtbxKredi";
            txtbxKredi.Size = new Size(202, 31);
            txtbxKredi.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 114);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 16;
            label3.Text = "Kredi : ";
            // 
            // DersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 551);
            Controls.Add(txtbxKredi);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtbxKod);
            Controls.Add(txtbxAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DersForm";
            Text = "Ders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnEkle;
        private TextBox txtbxKod;
        private TextBox txtbxAd;
        private Label label2;
        private Label label1;
        private TextBox txtbxKredi;
        private Label label3;
    }
}