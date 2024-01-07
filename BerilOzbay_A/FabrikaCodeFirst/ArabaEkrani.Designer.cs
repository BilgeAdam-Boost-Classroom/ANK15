namespace FabrikaCodeFirst
{
    partial class ArabaEkrani
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
            txtModel = new TextBox();
            txtYil = new TextBox();
            cbxPlaka = new ComboBox();
            cbxKisi = new ComboBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvArabalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 67);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 116);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "Yil:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 208);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Kisi Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 160);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Plaka Id:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(165, 64);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(184, 27);
            txtModel.TabIndex = 4;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(165, 109);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(184, 27);
            txtYil.TabIndex = 5;
            // 
            // cbxPlaka
            // 
            cbxPlaka.FormattingEnabled = true;
            cbxPlaka.Location = new Point(165, 152);
            cbxPlaka.Name = "cbxPlaka";
            cbxPlaka.Size = new Size(184, 28);
            cbxPlaka.TabIndex = 6;
            // 
            // cbxKisi
            // 
            cbxKisi.FormattingEnabled = true;
            cbxKisi.Location = new Point(165, 200);
            cbxKisi.Name = "cbxKisi";
            cbxKisi.Size = new Size(184, 28);
            cbxKisi.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(88, 262);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(188, 262);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(288, 262);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvArabalar
            // 
            dgvArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabalar.Location = new Point(400, 52);
            dgvArabalar.Name = "dgvArabalar";
            dgvArabalar.RowHeadersWidth = 51;
            dgvArabalar.RowTemplate.Height = 29;
            dgvArabalar.Size = new Size(660, 502);
            dgvArabalar.TabIndex = 11;
            dgvArabalar.CellClick += dgvArabalar_CellClick;
            // 
            // ArabaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 566);
            Controls.Add(dgvArabalar);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(cbxKisi);
            Controls.Add(cbxPlaka);
            Controls.Add(txtYil);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ArabaEkrani";
            Text = "ArabaEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtModel;
        private TextBox txtYil;
        private ComboBox cbxPlaka;
        private ComboBox cbxKisi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvArabalar;
    }
}