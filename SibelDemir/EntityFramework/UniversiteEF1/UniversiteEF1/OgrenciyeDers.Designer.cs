namespace UniversiteEF1
{
    partial class OgrenciyeDers
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
            cmbOgrenciler = new ComboBox();
            cmbDersler = new ComboBox();
            btnDersEkle = new Button();
            btnDersSil = new Button();
            dGWOgrenciyeDers = new DataGridView();
            lblOgrenciler = new Label();
            lblDersler = new Label();
            ((System.ComponentModel.ISupportInitialize)dGWOgrenciyeDers).BeginInit();
            SuspendLayout();
            // 
            // cmbOgrenciler
            // 
            cmbOgrenciler.FormattingEnabled = true;
            cmbOgrenciler.Location = new Point(77, 12);
            cmbOgrenciler.Name = "cmbOgrenciler";
            cmbOgrenciler.Size = new Size(121, 23);
            cmbOgrenciler.TabIndex = 0;
            cmbOgrenciler.SelectedIndexChanged += cmbOgrenciler_SelectedIndexChanged;
            // 
            // cmbDersler
            // 
            cmbDersler.FormattingEnabled = true;
            cmbDersler.Location = new Point(77, 44);
            cmbDersler.Name = "cmbDersler";
            cmbDersler.Size = new Size(121, 23);
            cmbDersler.TabIndex = 1;
            cmbDersler.SelectedIndexChanged += cmbDersler_SelectedIndexChanged;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(9, 118);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(75, 23);
            btnDersEkle.TabIndex = 2;
            btnDersEkle.Text = "Ders Ekle";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.Location = new Point(123, 118);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(75, 23);
            btnDersSil.TabIndex = 3;
            btnDersSil.Text = "Ders Sil";
            btnDersSil.UseVisualStyleBackColor = true;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // dGWOgrenciyeDers
            // 
            dGWOgrenciyeDers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGWOgrenciyeDers.Location = new Point(204, 12);
            dGWOgrenciyeDers.Name = "dGWOgrenciyeDers";
            dGWOgrenciyeDers.Size = new Size(581, 191);
            dGWOgrenciyeDers.TabIndex = 4;
            dGWOgrenciyeDers.CellClick += dGWOgrenciyeDers_CellClick;
            // 
            // lblOgrenciler
            // 
            lblOgrenciler.AutoSize = true;
            lblOgrenciler.Location = new Point(9, 17);
            lblOgrenciler.Name = "lblOgrenciler";
            lblOgrenciler.Size = new Size(62, 15);
            lblOgrenciler.TabIndex = 5;
            lblOgrenciler.Text = "Öğrenciler";
            // 
            // lblDersler
            // 
            lblDersler.AutoSize = true;
            lblDersler.Location = new Point(9, 52);
            lblDersler.Name = "lblDersler";
            lblDersler.Size = new Size(43, 15);
            lblDersler.TabIndex = 6;
            lblDersler.Text = "Dersler";
            // 
            // OgrenciyeDers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 225);
            Controls.Add(lblDersler);
            Controls.Add(lblOgrenciler);
            Controls.Add(dGWOgrenciyeDers);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersEkle);
            Controls.Add(cmbDersler);
            Controls.Add(cmbOgrenciler);
            Name = "OgrenciyeDers";
            Text = "OgrenciyeDers";
            ((System.ComponentModel.ISupportInitialize)dGWOgrenciyeDers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOgrenciler;
        private ComboBox cmbDersler;
        private Button btnDersEkle;
        private Button btnDersSil;
        private DataGridView dGWOgrenciyeDers;
        private Label lblOgrenciler;
        private Label lblDersler;
    }
}