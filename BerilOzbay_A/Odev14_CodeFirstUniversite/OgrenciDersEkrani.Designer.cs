namespace CodeFirstUniversite
{
    partial class OgrenciDersEkrani
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
            dgvOgrenciDers = new DataGridView();
            cbxOgrenci = new ComboBox();
            cbxDers = new ComboBox();
            cbxNot = new ComboBox();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciDers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 85);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Ders:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(723, 85);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "Not:";
            // 
            // dgvOgrenciDers
            // 
            dgvOgrenciDers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciDers.Location = new Point(80, 131);
            dgvOgrenciDers.Name = "dgvOgrenciDers";
            dgvOgrenciDers.RowHeadersWidth = 51;
            dgvOgrenciDers.RowTemplate.Height = 29;
            dgvOgrenciDers.Size = new Size(958, 373);
            dgvOgrenciDers.TabIndex = 3;
            dgvOgrenciDers.CellClick += dgvOgrenciDers_CellClick;
            // 
            // cbxOgrenci
            // 
            cbxOgrenci.FormattingEnabled = true;
            cbxOgrenci.Location = new Point(196, 82);
            cbxOgrenci.Name = "cbxOgrenci";
            cbxOgrenci.Size = new Size(188, 28);
            cbxOgrenci.TabIndex = 4;
            // 
            // cbxDers
            // 
            cbxDers.FormattingEnabled = true;
            cbxDers.Location = new Point(464, 82);
            cbxDers.Name = "cbxDers";
            cbxDers.Size = new Size(232, 28);
            cbxDers.TabIndex = 5;
            // 
            // cbxNot
            // 
            cbxNot.FormattingEnabled = true;
            cbxNot.Location = new Point(766, 85);
            cbxNot.Name = "cbxNot";
            cbxNot.Size = new Size(201, 28);
            cbxNot.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(196, 538);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(161, 43);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(737, 538);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(161, 43);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // OgrenciDersEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 610);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(cbxNot);
            Controls.Add(cbxDers);
            Controls.Add(cbxOgrenci);
            Controls.Add(dgvOgrenciDers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciDersEkrani";
            Text = "OgrenciDersEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciDers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvOgrenciDers;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDers;
        private ComboBox cbxNot;
        private Button btnEkle;
        private Button btnSil;
    }
}