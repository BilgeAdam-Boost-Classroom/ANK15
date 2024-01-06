namespace SchoolWindowsForm
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
            txtbxNo = new TextBox();
            txtbxTarih = new TextBox();
            btnEkle = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Diploma No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 92);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Diploma tarihi : ";
            // 
            // txtbxNo
            // 
            txtbxNo.Location = new Point(121, 52);
            txtbxNo.Name = "txtbxNo";
            txtbxNo.Size = new Size(172, 23);
            txtbxNo.TabIndex = 2;
            // 
            // txtbxTarih
            // 
            txtbxTarih.Location = new Point(121, 89);
            txtbxTarih.Name = "txtbxTarih";
            txtbxTarih.Size = new Size(172, 23);
            txtbxTarih.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(24, 132);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(118, 132);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 5;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(218, 132);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(267, 228);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // label3
            // 
            label3.Location = new Point(24, 405);
            label3.Name = "label3";
            label3.Size = new Size(267, 36);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtbxTarih);
            Controls.Add(txtbxNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbxNo;
        private TextBox txtbxTarih;
        private Button btnEkle;
        private Button btnGüncelle;
        private Button btnSil;
        private DataGridView dataGridView1;
        private Label label3;
    }
}
