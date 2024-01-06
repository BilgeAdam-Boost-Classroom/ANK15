namespace ANK15Burger
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
            label1 = new Label();
            cbxMenu = new ComboBox();
            label3 = new Label();
            chkListMalzeme = new CheckedListBox();
            grpbxBoyut = new GroupBox();
            cbxAdet = new ComboBox();
            label2 = new Label();
            btnEkle = new Button();
            pictureBox1 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            listBoxSiparisler = new ListBox();
            label4 = new Label();
            lblPrice = new Label();
            button1 = new Button();
            lblCurrency = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 280);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 6;
            label1.Text = "MENÜ SEÇİN";
            // 
            // cbxMenu
            // 
            cbxMenu.FormattingEnabled = true;
            cbxMenu.Location = new Point(17, 310);
            cbxMenu.Margin = new Padding(4, 5, 4, 5);
            cbxMenu.Name = "cbxMenu";
            cbxMenu.Size = new Size(393, 33);
            cbxMenu.TabIndex = 7;
            cbxMenu.SelectedIndexChanged += cbxMenu_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 458);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 13;
            label3.Text = "MALZEME SEÇİN";
            // 
            // chkListMalzeme
            // 
            chkListMalzeme.FormattingEnabled = true;
            chkListMalzeme.Location = new Point(23, 488);
            chkListMalzeme.Margin = new Padding(4, 5, 4, 5);
            chkListMalzeme.MultiColumn = true;
            chkListMalzeme.Name = "chkListMalzeme";
            chkListMalzeme.Size = new Size(387, 144);
            chkListMalzeme.TabIndex = 10;
            chkListMalzeme.SelectedIndexChanged += chkListMalzeme_SelectedIndexChanged_1;
            // 
            // grpbxBoyut
            // 
            grpbxBoyut.Location = new Point(17, 358);
            grpbxBoyut.Margin = new Padding(4, 5, 4, 5);
            grpbxBoyut.Name = "grpbxBoyut";
            grpbxBoyut.Padding = new Padding(4, 5, 4, 5);
            grpbxBoyut.Size = new Size(394, 95);
            grpbxBoyut.TabIndex = 13;
            grpbxBoyut.TabStop = false;
            grpbxBoyut.Text = "BOYUT SEÇİNİZ";
            grpbxBoyut.Enter += grpbxBoyut_Enter;
            // 
            // cbxAdet
            // 
            cbxAdet.FormattingEnabled = true;
            cbxAdet.Location = new Point(17, 692);
            cbxAdet.Margin = new Padding(4, 5, 4, 5);
            cbxAdet.Name = "cbxAdet";
            cbxAdet.Size = new Size(171, 33);
            cbxAdet.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 663);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 15;
            label2.Text = "ADET";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(230, 663);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(181, 67);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "SİPARİŞ EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(286, 758);
            checkedListBox1.Margin = new Padding(4, 5, 4, 5);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(10, 4);
            checkedListBox1.TabIndex = 18;
            // 
            // listBoxSiparisler
            // 
            listBoxSiparisler.FormattingEnabled = true;
            listBoxSiparisler.ItemHeight = 25;
            listBoxSiparisler.Location = new Point(464, 20);
            listBoxSiparisler.Margin = new Padding(4, 5, 4, 5);
            listBoxSiparisler.Name = "listBoxSiparisler";
            listBoxSiparisler.Size = new Size(395, 629);
            listBoxSiparisler.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 685);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 20;
            label4.Text = "TOPLAM TUTAR : ";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(591, 685);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 25);
            lblPrice.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(694, 672);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(167, 68);
            button1.TabIndex = 22;
            button1.Text = "SİPARİŞİ TAMAMLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(656, 685);
            lblCurrency.Margin = new Padding(4, 0, 4, 0);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(0, 25);
            lblCurrency.TabIndex = 23;
            // 
            // SiparisEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 755);
            Controls.Add(lblCurrency);
            Controls.Add(button1);
            Controls.Add(lblPrice);
            Controls.Add(listBoxSiparisler);
            Controls.Add(checkedListBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(cbxAdet);
            Controls.Add(chkListMalzeme);
            Controls.Add(label3);
            Controls.Add(cbxMenu);
            Controls.Add(label1);
            Controls.Add(grpbxBoyut);
            Controls.Add(label4);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SiparisEkleme";
            Text = "SiparisEkleme";
            Load += SiparisEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxMenu;
        private Label label3;
        private CheckedListBox chkListMalzeme;
        private GroupBox grpbxBoyut;
        private ComboBox cbxAdet;
        private Label label2;
        private Button btnEkle;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private ListBox listBoxSiparisler;
        private Label label4;
        private Label lblPrice;
        private Button button1;
        private Label lblCurrency;
    }
}