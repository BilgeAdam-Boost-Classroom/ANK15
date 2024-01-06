namespace OkulExerciseWF
{
    partial class OgrenciDersForm
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
            label3 = new Label();
            cbxOgrenci = new ComboBox();
            cbxDers = new ComboBox();
            txtNot = new TextBox();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Ders : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(764, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Not : ";
            // 
            // cbxOgrenci
            // 
            cbxOgrenci.FormattingEnabled = true;
            cbxOgrenci.Location = new Point(151, 120);
            cbxOgrenci.Margin = new Padding(4, 5, 4, 5);
            cbxOgrenci.Name = "cbxOgrenci";
            cbxOgrenci.Size = new Size(199, 33);
            cbxOgrenci.TabIndex = 3;
            // 
            // cbxDers
            // 
            cbxDers.FormattingEnabled = true;
            cbxDers.Location = new Point(491, 120);
            cbxDers.Margin = new Padding(4, 5, 4, 5);
            cbxDers.Name = "cbxDers";
            cbxDers.Size = new Size(211, 33);
            cbxDers.TabIndex = 4;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(824, 120);
            txtNot.Margin = new Padding(4, 5, 4, 5);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(187, 31);
            txtNot.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 267);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(989, 425);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(87, 187);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(184, 55);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(829, 187);
            btnSil.Margin = new Padding(4, 5, 4, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(184, 55);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // OgrenciDersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(txtNot);
            Controls.Add(cbxDers);
            Controls.Add(cbxOgrenci);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OgrenciDersForm";
            Text = "OgrenciDers";
            Load += OgrenciDersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDers;
        private TextBox txtNot;
        private DataGridView dataGridView1;
        private Button btnEkle;
        private Button btnSil;
    }
}