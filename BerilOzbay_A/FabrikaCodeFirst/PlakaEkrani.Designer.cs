namespace FabrikaCodeFirst
{
    partial class PlakaEkrani
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
            txtKod = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvPlakalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlakalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 73);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Plaka Kodu:";
            // 
            // txtKod
            // 
            txtKod.Location = new Point(175, 73);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(214, 27);
            txtKod.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(71, 139);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(182, 139);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(295, 139);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvPlakalar
            // 
            dgvPlakalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlakalar.Location = new Point(451, 73);
            dgvPlakalar.Name = "dgvPlakalar";
            dgvPlakalar.RowHeadersWidth = 51;
            dgvPlakalar.RowTemplate.Height = 29;
            dgvPlakalar.Size = new Size(375, 364);
            dgvPlakalar.TabIndex = 5;
            dgvPlakalar.CellClick += dgvPlakalar_CellClick;
            // 
            // PlakaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 529);
            Controls.Add(dgvPlakalar);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtKod);
            Controls.Add(label1);
            Name = "PlakaEkrani";
            Text = "PlakaEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvPlakalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKod;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvPlakalar;
    }
}