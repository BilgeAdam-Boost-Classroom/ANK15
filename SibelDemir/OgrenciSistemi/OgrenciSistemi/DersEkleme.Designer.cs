namespace OgrenciSistemi
{
    partial class DersEkleme
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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnOgreciyeDersEkle = new Button();
            btnOgrencidenDersCikar = new Button();
            btnTranscriptGor = new Button();
            cmbxOgrenci = new ComboBox();
            cmbxDers = new ComboBox();
            cmbxDonem = new ComboBox();
            cmbxHarfNotu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 42);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 1;
            label2.Text = "Ders:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(606, 42);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Dönem:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(901, 44);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 3;
            label4.Text = "Harf Notu:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 144);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1179, 225);
            dataGridView1.TabIndex = 4;
            // 
            // btnOgreciyeDersEkle
            // 
            btnOgreciyeDersEkle.Location = new Point(54, 456);
            btnOgreciyeDersEkle.Name = "btnOgreciyeDersEkle";
            btnOgreciyeDersEkle.Size = new Size(187, 72);
            btnOgreciyeDersEkle.TabIndex = 5;
            btnOgreciyeDersEkle.Text = "Öğrenciye Ders Ekle";
            btnOgreciyeDersEkle.UseVisualStyleBackColor = true;
            btnOgreciyeDersEkle.Click += btnOgreciyeDersEkle_Click;
            // 
            // btnOgrencidenDersCikar
            // 
            btnOgrencidenDersCikar.Location = new Point(499, 456);
            btnOgrencidenDersCikar.Name = "btnOgrencidenDersCikar";
            btnOgrencidenDersCikar.Size = new Size(199, 72);
            btnOgrencidenDersCikar.TabIndex = 6;
            btnOgrencidenDersCikar.Text = "Öğrenciden Ders Çıkar";
            btnOgrencidenDersCikar.UseVisualStyleBackColor = true;
            btnOgrencidenDersCikar.Click += btnOgrencidenDersCikar_Click;
            // 
            // btnTranscriptGor
            // 
            btnTranscriptGor.Location = new Point(936, 456);
            btnTranscriptGor.Name = "btnTranscriptGor";
            btnTranscriptGor.Size = new Size(176, 72);
            btnTranscriptGor.TabIndex = 7;
            btnTranscriptGor.Text = "Transcript Gör";
            btnTranscriptGor.UseVisualStyleBackColor = true;
            btnTranscriptGor.Click += btnTranscriptGor_Click;
            // 
            // cmbxOgrenci
            // 
            cmbxOgrenci.FormattingEnabled = true;
            cmbxOgrenci.Location = new Point(103, 39);
            cmbxOgrenci.Name = "cmbxOgrenci";
            cmbxOgrenci.Size = new Size(182, 33);
            cmbxOgrenci.TabIndex = 8;
            // 
            // cmbxDers
            // 
            cmbxDers.FormattingEnabled = true;
            cmbxDers.Location = new Point(368, 39);
            cmbxDers.Name = "cmbxDers";
            cmbxDers.Size = new Size(182, 33);
            cmbxDers.TabIndex = 9;
            // 
            // cmbxDonem
            // 
            cmbxDonem.FormattingEnabled = true;
            cmbxDonem.Location = new Point(681, 39);
            cmbxDonem.Name = "cmbxDonem";
            cmbxDonem.Size = new Size(182, 33);
            cmbxDonem.TabIndex = 10;
            // 
            // cmbxHarfNotu
            // 
            cmbxHarfNotu.FormattingEnabled = true;
            cmbxHarfNotu.Location = new Point(1002, 39);
            cmbxHarfNotu.Name = "cmbxHarfNotu";
            cmbxHarfNotu.Size = new Size(182, 33);
            cmbxHarfNotu.TabIndex = 11;
            // 
            // DersEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 667);
            Controls.Add(cmbxHarfNotu);
            Controls.Add(cmbxDonem);
            Controls.Add(cmbxDers);
            Controls.Add(cmbxOgrenci);
            Controls.Add(btnTranscriptGor);
            Controls.Add(btnOgrencidenDersCikar);
            Controls.Add(btnOgreciyeDersEkle);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DersEkleme";
            Text = "DersEkleme";
            Load += DersEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnOgreciyeDersEkle;
        private Button btnOgrencidenDersCikar;
        private Button btnTranscriptGor;
        private ComboBox cmbxOgrenci;
        private ComboBox cmbxDers;
        private ComboBox cmbxDonem;
        private ComboBox cmbxHarfNotu;
    }
}