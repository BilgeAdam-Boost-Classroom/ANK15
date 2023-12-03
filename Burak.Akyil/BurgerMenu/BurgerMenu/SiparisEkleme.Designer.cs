namespace BurgerMenu
{
    partial class SiparisEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkleme));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbMenu = new ComboBox();
            rdbKucuk = new RadioButton();
            groupBox1 = new GroupBox();
            rdbBuyuk = new RadioButton();
            rdbOrta = new RadioButton();
            clbSos = new CheckedListBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnSipraisEkle = new Button();
            lblTutar = new Label();
            lblSiparis = new ListBox();
            btnTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenu
            // 
            cmbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(12, 147);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(121, 23);
            cmbMenu.TabIndex = 2;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbKucuk.Location = new Point(6, 22);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(60, 19);
            rdbKucuk.TabIndex = 3;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbBuyuk);
            groupBox1.Controls.Add(rdbOrta);
            groupBox1.Controls.Add(rdbKucuk);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 58);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbBuyuk.Location = new Point(128, 22);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(60, 19);
            rdbBuyuk.TabIndex = 5;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbOrta.Location = new Point(72, 22);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(50, 19);
            rdbOrta.TabIndex = 4;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // clbSos
            // 
            clbSos.FormattingEnabled = true;
            clbSos.Location = new Point(12, 240);
            clbSos.Name = "clbSos";
            clbSos.ScrollAlwaysVisible = true;
            clbSos.Size = new Size(126, 112);
            clbSos.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 364);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "ADET";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(55, 362);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // btnSipraisEkle
            // 
            btnSipraisEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSipraisEkle.Location = new Point(12, 391);
            btnSipraisEkle.Name = "btnSipraisEkle";
            btnSipraisEkle.Size = new Size(121, 37);
            btnSipraisEkle.TabIndex = 8;
            btnSipraisEkle.Text = "SİPARİŞ EKLE";
            btnSipraisEkle.UseVisualStyleBackColor = true;
            btnSipraisEkle.Click += btnSipraisEkle_Click;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutar.Location = new Point(175, 402);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(0, 15);
            lblTutar.TabIndex = 10;
            // 
            // lblSiparis
            // 
            lblSiparis.FormattingEnabled = true;
            lblSiparis.ItemHeight = 15;
            lblSiparis.Location = new Point(218, 12);
            lblSiparis.Name = "lblSiparis";
            lblSiparis.Size = new Size(296, 364);
            lblSiparis.TabIndex = 11;
            // 
            // btnTamamla
            // 
            btnTamamla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTamamla.Location = new Point(385, 391);
            btnTamamla.Name = "btnTamamla";
            btnTamamla.Size = new Size(129, 38);
            btnTamamla.TabIndex = 12;
            btnTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnTamamla.UseVisualStyleBackColor = true;
            // 
            // SiparisEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 441);
            Controls.Add(btnTamamla);
            Controls.Add(lblSiparis);
            Controls.Add(lblTutar);
            Controls.Add(btnSipraisEkle);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(clbSos);
            Controls.Add(groupBox1);
            Controls.Add(cmbMenu);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SiparisEkleme";
            Text = "SiparisEkleme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbMenu;
        private RadioButton rdbKucuk;
        private GroupBox groupBox1;
        private RadioButton rdbBuyuk;
        private RadioButton rdbOrta;
        private CheckedListBox clbSos;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button btnSipraisEkle;
        private Label lblTutar;
        private ListBox lblSiparis;
        private Button btnTamamla;
    }
}