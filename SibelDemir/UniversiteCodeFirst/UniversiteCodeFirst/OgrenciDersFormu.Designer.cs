namespace UniversiteCodeFirst
{
    partial class OgrenciDersFormu
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
            cmbOgrenci = new ComboBox();
            cmbDers = new ComboBox();
            cmbNot = new ComboBox();
            dgvOD = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOD).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 53);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Ders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 56);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Not";
            // 
            // cmbOgrenci
            // 
            cmbOgrenci.FormattingEnabled = true;
            cmbOgrenci.Location = new Point(79, 53);
            cmbOgrenci.Name = "cmbOgrenci";
            cmbOgrenci.Size = new Size(121, 23);
            cmbOgrenci.TabIndex = 4;
            cmbOgrenci.SelectedIndexChanged += cmbOgrenci_SelectedIndexChanged;
            // 
            // cmbDers
            // 
            cmbDers.FormattingEnabled = true;
            cmbDers.Location = new Point(280, 53);
            cmbDers.Name = "cmbDers";
            cmbDers.Size = new Size(121, 23);
            cmbDers.TabIndex = 5;
            // 
            // cmbNot
            // 
            cmbNot.FormattingEnabled = true;
            cmbNot.Location = new Point(469, 53);
            cmbNot.Name = "cmbNot";
            cmbNot.Size = new Size(121, 23);
            cmbNot.TabIndex = 6;
            // 
            // dgvOD
            // 
            dgvOD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOD.Location = new Point(19, 110);
            dgvOD.Name = "dgvOD";
            dgvOD.Size = new Size(591, 173);
            dgvOD.TabIndex = 7;
            dgvOD.CellClick += dgvOD_CellClick;
            dgvOD.CellContentClick += dgvOD_CellContentClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(19, 317);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 48);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(535, 317);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 48);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // OgrenciDersFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvOD);
            Controls.Add(cmbNot);
            Controls.Add(cmbDers);
            Controls.Add(cmbOgrenci);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciDersFormu";
            Text = "OgrenciDersFormu";
            Load += OgrenciDersFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbOgrenci;
        private ComboBox cmbDers;
        private ComboBox cmbNot;
        private DataGridView dgvOD;
        private Button btnEkle;
        private Button btnSil;
    }
}