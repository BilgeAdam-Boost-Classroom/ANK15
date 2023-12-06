namespace Burger
{
    partial class MenuEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEkleme));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblToplam = new Label();
            lblTutar = new Label();
            cbxMenuSec = new ComboBox();
            gbx = new GroupBox();
            rbtnBuyuk = new RadioButton();
            rbtnOrta = new RadioButton();
            rbtnkucuk = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            btnSiparişEkle = new Button();
            btnSiparişTamamla = new Button();
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 283);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİN";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 712);
            label2.Name = "label2";
            label2.Size = new Size(88, 38);
            label2.TabIndex = 2;
            label2.Text = "ADET";
            // 
            // lblToplam
            // 
            lblToplam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplam.Location = new Point(343, 791);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(191, 38);
            lblToplam.TabIndex = 3;
            lblToplam.Text = "TOPLAM TUTAR:";
            // 
            // lblTutar
            // 
            lblTutar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTutar.Location = new Point(540, 791);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(88, 38);
            lblTutar.TabIndex = 4;
            lblTutar.Text = "₺0,00";
            // 
            // cbxMenuSec
            // 
            cbxMenuSec.DisplayMember = "MenuName";
            cbxMenuSec.FormattingEnabled = true;
            cbxMenuSec.Location = new Point(44, 342);
            cbxMenuSec.Name = "cbxMenuSec";
            cbxMenuSec.Size = new Size(317, 33);
            cbxMenuSec.TabIndex = 11;
            // 
            // gbx
            // 
            gbx.Controls.Add(rbtnBuyuk);
            gbx.Controls.Add(rbtnOrta);
            gbx.Controls.Add(rbtnkucuk);
            gbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbx.Location = new Point(44, 405);
            gbx.Name = "gbx";
            gbx.Size = new Size(317, 76);
            gbx.TabIndex = 12;
            gbx.TabStop = false;
            gbx.Text = "BOYUT SEÇİNİZ";
            // 
            // rbtnBuyuk
            // 
            rbtnBuyuk.AutoSize = true;
            rbtnBuyuk.Location = new Point(206, 35);
            rbtnBuyuk.Name = "rbtnBuyuk";
            rbtnBuyuk.Size = new Size(105, 36);
            rbtnBuyuk.TabIndex = 2;
            rbtnBuyuk.TabStop = true;
            rbtnBuyuk.Text = "Büyük";
            rbtnBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbtnOrta
            // 
            rbtnOrta.AutoSize = true;
            rbtnOrta.Location = new Point(115, 34);
            rbtnOrta.Name = "rbtnOrta";
            rbtnOrta.Size = new Size(85, 36);
            rbtnOrta.TabIndex = 1;
            rbtnOrta.TabStop = true;
            rbtnOrta.Text = "Orta";
            rbtnOrta.UseVisualStyleBackColor = true;
            // 
            // rbtnkucuk
            // 
            rbtnkucuk.AutoSize = true;
            rbtnkucuk.Location = new Point(6, 35);
            rbtnkucuk.Name = "rbtnkucuk";
            rbtnkucuk.Size = new Size(104, 36);
            rbtnkucuk.TabIndex = 0;
            rbtnkucuk.TabStop = true;
            rbtnkucuk.Text = "Küçük";
            rbtnkucuk.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(126, 712);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 19;
            // 
            // btnSiparişEkle
            // 
            btnSiparişEkle.BackColor = Color.DarkOrange;
            btnSiparişEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparişEkle.Location = new Point(55, 768);
            btnSiparişEkle.Name = "btnSiparişEkle";
            btnSiparişEkle.Size = new Size(257, 78);
            btnSiparişEkle.TabIndex = 20;
            btnSiparişEkle.Text = "SİPARİŞ EKLE";
            btnSiparişEkle.UseVisualStyleBackColor = false;
            btnSiparişEkle.Click += btnSiparişEkle_Click;
            // 
            // btnSiparişTamamla
            // 
            btnSiparişTamamla.BackColor = Color.DarkOrange;
            btnSiparişTamamla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparişTamamla.Location = new Point(633, 768);
            btnSiparişTamamla.Name = "btnSiparişTamamla";
            btnSiparişTamamla.Size = new Size(257, 78);
            btnSiparişTamamla.TabIndex = 21;
            btnSiparişTamamla.Text = "SİPARİŞ TAMAMLA";
            btnSiparişTamamla.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(50, 519);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 190);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "MALZEME SEÇİN";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(14, 36);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(280, 148);
            checkedListBox1.TabIndex = 25;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(434, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(456, 729);
            listBox1.TabIndex = 24;
            // 
            // MenuEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(949, 1012);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnSiparişTamamla);
            Controls.Add(btnSiparişEkle);
            Controls.Add(numericUpDown1);
            Controls.Add(gbx);
            Controls.Add(cbxMenuSec);
            Controls.Add(lblTutar);
            Controls.Add(lblToplam);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MenuEkleme";
            Text = "MenuEkleme";
            Load += MenuEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbx.ResumeLayout(false);
            gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblToplam;
        private Label lblTutar;
        private ComboBox cbxMenuSec;
        private GroupBox gbx;
        private RadioButton rbtnBuyuk;
        private RadioButton rbtnOrta;
        private RadioButton rbtnkucuk;
        private NumericUpDown numericUpDown1;
        private Button btnSiparişEkle;
        private Button btnSiparişTamamla;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
    }
}