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
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 13);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 170);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİN";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 427);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 2;
            label2.Text = "ADET";
            // 
            // lblToplam
            // 
            lblToplam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplam.Location = new Point(240, 475);
            lblToplam.Margin = new Padding(2, 0, 2, 0);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(134, 23);
            lblToplam.TabIndex = 3;
            lblToplam.Text = "TOPLAM TUTAR:";
            // 
            // lblTutar
            // 
            lblTutar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTutar.Location = new Point(378, 475);
            lblTutar.Margin = new Padding(2, 0, 2, 0);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(62, 23);
            lblTutar.TabIndex = 4;
            lblTutar.Text = "₺0,00";
            // 
            // cbxMenuSec
            // 
            cbxMenuSec.DisplayMember = "MenuName";
            cbxMenuSec.FormattingEnabled = true;
            cbxMenuSec.Location = new Point(31, 205);
            cbxMenuSec.Margin = new Padding(2, 2, 2, 2);
            cbxMenuSec.Name = "cbxMenuSec";
            cbxMenuSec.Size = new Size(223, 23);
            cbxMenuSec.TabIndex = 11;
            // 
            // gbx
            // 
            gbx.Controls.Add(rbtnBuyuk);
            gbx.Controls.Add(rbtnOrta);
            gbx.Controls.Add(rbtnkucuk);
            gbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbx.Location = new Point(31, 243);
            gbx.Margin = new Padding(2, 2, 2, 2);
            gbx.Name = "gbx";
            gbx.Padding = new Padding(2, 2, 2, 2);
            gbx.Size = new Size(222, 46);
            gbx.TabIndex = 12;
            gbx.TabStop = false;
            gbx.Text = "BOYUT SEÇİNİZ";
            // 
            // rbtnBuyuk
            // 
            rbtnBuyuk.AutoSize = true;
            rbtnBuyuk.Location = new Point(144, 21);
            rbtnBuyuk.Margin = new Padding(2, 2, 2, 2);
            rbtnBuyuk.Name = "rbtnBuyuk";
            rbtnBuyuk.Size = new Size(71, 25);
            rbtnBuyuk.TabIndex = 2;
            rbtnBuyuk.TabStop = true;
            rbtnBuyuk.Text = "Büyük";
            rbtnBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbtnOrta
            // 
            rbtnOrta.AutoSize = true;
            rbtnOrta.Location = new Point(80, 20);
            rbtnOrta.Margin = new Padding(2, 2, 2, 2);
            rbtnOrta.Name = "rbtnOrta";
            rbtnOrta.Size = new Size(59, 25);
            rbtnOrta.TabIndex = 1;
            rbtnOrta.TabStop = true;
            rbtnOrta.Text = "Orta";
            rbtnOrta.UseVisualStyleBackColor = true;
            // 
            // rbtnkucuk
            // 
            rbtnkucuk.AutoSize = true;
            rbtnkucuk.Location = new Point(4, 21);
            rbtnkucuk.Margin = new Padding(2, 2, 2, 2);
            rbtnkucuk.Name = "rbtnkucuk";
            rbtnkucuk.Size = new Size(70, 25);
            rbtnkucuk.TabIndex = 0;
            rbtnkucuk.TabStop = true;
            rbtnkucuk.Text = "Küçük";
            rbtnkucuk.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(88, 427);
            numericUpDown1.Margin = new Padding(2, 2, 2, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // btnSiparişEkle
            // 
            btnSiparişEkle.BackColor = Color.DarkOrange;
            btnSiparişEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparişEkle.Location = new Point(38, 461);
            btnSiparişEkle.Margin = new Padding(2, 2, 2, 2);
            btnSiparişEkle.Name = "btnSiparişEkle";
            btnSiparişEkle.Size = new Size(180, 47);
            btnSiparişEkle.TabIndex = 20;
            btnSiparişEkle.Text = "SİPARİŞ EKLE";
            btnSiparişEkle.UseVisualStyleBackColor = false;
            btnSiparişEkle.Click += btnSiparişEkle_Click;
            // 
            // btnSiparişTamamla
            // 
            btnSiparişTamamla.BackColor = Color.DarkOrange;
            btnSiparişTamamla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparişTamamla.Location = new Point(443, 461);
            btnSiparişTamamla.Margin = new Padding(2, 2, 2, 2);
            btnSiparişTamamla.Name = "btnSiparişTamamla";
            btnSiparişTamamla.Size = new Size(180, 47);
            btnSiparişTamamla.TabIndex = 21;
            btnSiparişTamamla.Text = "SİPARİŞ TAMAMLA";
            btnSiparişTamamla.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 311);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(218, 114);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "MALZEME SEÇİN";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(10, 22);
            checkedListBox1.Margin = new Padding(2, 2, 2, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(197, 76);
            checkedListBox1.TabIndex = 25;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(304, 13);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(320, 439);
            listBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(255, 540);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(58, 536);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(59, 560);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // MenuEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(664, 607);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuEkleme";
            Text = "MenuEkleme";
            Load += MenuEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbx.ResumeLayout(false);
            gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}