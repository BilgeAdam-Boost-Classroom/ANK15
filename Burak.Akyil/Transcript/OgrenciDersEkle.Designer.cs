namespace Transcript
{
    partial class OgrenciDersEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxOgrenci = new System.Windows.Forms.ComboBox();
            this.cbxDers = new System.Windows.Forms.ComboBox();
            this.cbxDonem = new System.Windows.Forms.ComboBox();
            this.cbxHarfNotu = new System.Windows.Forms.ComboBox();
            this.dataGridOgrenciDers = new System.Windows.Forms.DataGridView();
            this.btnOgrenciDersEkle = new System.Windows.Forms.Button();
            this.btnOgrenciDersCıkar = new System.Windows.Forms.Button();
            this.btnTranscript = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenciDers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dönem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harf Notu:";
            // 
            // cbxOgrenci
            // 
            this.cbxOgrenci.FormattingEnabled = true;
            this.cbxOgrenci.Location = new System.Drawing.Point(103, 26);
            this.cbxOgrenci.Name = "cbxOgrenci";
            this.cbxOgrenci.Size = new System.Drawing.Size(121, 23);
            this.cbxOgrenci.TabIndex = 4;
            // 
            // cbxDers
            // 
            this.cbxDers.FormattingEnabled = true;
            this.cbxDers.Location = new System.Drawing.Point(269, 26);
            this.cbxDers.Name = "cbxDers";
            this.cbxDers.Size = new System.Drawing.Size(121, 23);
            this.cbxDers.TabIndex = 4;
            // 
            // cbxDonem
            // 
            this.cbxDonem.FormattingEnabled = true;
            this.cbxDonem.Location = new System.Drawing.Point(453, 26);
            this.cbxDonem.Name = "cbxDonem";
            this.cbxDonem.Size = new System.Drawing.Size(121, 23);
            this.cbxDonem.TabIndex = 4;
            // 
            // cbxHarfNotu
            // 
            this.cbxHarfNotu.FormattingEnabled = true;
            this.cbxHarfNotu.Location = new System.Drawing.Point(649, 26);
            this.cbxHarfNotu.Name = "cbxHarfNotu";
            this.cbxHarfNotu.Size = new System.Drawing.Size(121, 23);
            this.cbxHarfNotu.TabIndex = 4;
            // 
            // dataGridOgrenciDers
            // 
            this.dataGridOgrenciDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOgrenciDers.Location = new System.Drawing.Point(103, 80);
            this.dataGridOgrenciDers.Name = "dataGridOgrenciDers";
            this.dataGridOgrenciDers.RowTemplate.Height = 25;
            this.dataGridOgrenciDers.Size = new System.Drawing.Size(667, 221);
            this.dataGridOgrenciDers.TabIndex = 5;
            this.dataGridOgrenciDers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOgrenciDers_CellClick);
            // 
            // btnOgrenciDersEkle
            // 
            this.btnOgrenciDersEkle.Location = new System.Drawing.Point(103, 349);
            this.btnOgrenciDersEkle.Name = "btnOgrenciDersEkle";
            this.btnOgrenciDersEkle.Size = new System.Drawing.Size(160, 38);
            this.btnOgrenciDersEkle.TabIndex = 6;
            this.btnOgrenciDersEkle.Text = "Öğrenciye Ders Ekle";
            this.btnOgrenciDersEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciDersEkle.Click += new System.EventHandler(this.btnOgrenciDersEkle_Click);
            // 
            // btnOgrenciDersCıkar
            // 
            this.btnOgrenciDersCıkar.Location = new System.Drawing.Point(315, 349);
            this.btnOgrenciDersCıkar.Name = "btnOgrenciDersCıkar";
            this.btnOgrenciDersCıkar.Size = new System.Drawing.Size(159, 38);
            this.btnOgrenciDersCıkar.TabIndex = 7;
            this.btnOgrenciDersCıkar.Text = "Öğrenciden Ders Çıkar";
            this.btnOgrenciDersCıkar.UseVisualStyleBackColor = true;
            this.btnOgrenciDersCıkar.Click += new System.EventHandler(this.btnOgrenciDersCıkar_Click);
            // 
            // btnTranscript
            // 
            this.btnTranscript.Location = new System.Drawing.Point(518, 349);
            this.btnTranscript.Name = "btnTranscript";
            this.btnTranscript.Size = new System.Drawing.Size(165, 38);
            this.btnTranscript.TabIndex = 8;
            this.btnTranscript.Text = "Transcript Gör";
            this.btnTranscript.UseVisualStyleBackColor = true;
            this.btnTranscript.Click += new System.EventHandler(this.btnTranscript_Click);
            // 
            // OgrenciDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTranscript);
            this.Controls.Add(this.btnOgrenciDersCıkar);
            this.Controls.Add(this.btnOgrenciDersEkle);
            this.Controls.Add(this.dataGridOgrenciDers);
            this.Controls.Add(this.cbxHarfNotu);
            this.Controls.Add(this.cbxDonem);
            this.Controls.Add(this.cbxDers);
            this.Controls.Add(this.cbxOgrenci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciDersEkle";
            this.Text = "OgrenciDersEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenciDers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDers;
        private ComboBox cbxDonem;
        private ComboBox cbxHarfNotu;
        private DataGridView dataGridOgrenciDers;
        private Button btnOgrenciDersEkle;
        private Button btnOgrenciDersCıkar;
        private Button btnTranscript;
    }
}