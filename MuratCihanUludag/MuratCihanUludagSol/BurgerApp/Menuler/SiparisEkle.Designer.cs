namespace BurgerApp
{
    partial class SiparisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkle));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBoxMenu = new ComboBox();
            label2 = new Label();
            radioSmall = new RadioButton();
            radioMid = new RadioButton();
            radioKing = new RadioButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            PriaceLabel = new Label();
            button2 = new Button();
            checkedListMalzeme = new CheckedListBox();
            ToplamMalzemeFiyati = new Label();
            Hesapla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 154);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 1;
            label1.Text = "Menu Seçin";
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.FormattingEnabled = true;
            comboBoxMenu.Location = new Point(42, 204);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(381, 23);
            comboBoxMenu.TabIndex = 2;
            comboBoxMenu.SelectedIndexChanged += comboBoxMenu_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 251);
            label2.Name = "label2";
            label2.Size = new Size(167, 37);
            label2.TabIndex = 3;
            label2.Text = "Boyut Secin";
            // 
            // radioSmall
            // 
            radioSmall.AutoSize = true;
            radioSmall.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioSmall.Location = new Point(24, 22);
            radioSmall.Name = "radioSmall";
            radioSmall.Size = new Size(88, 34);
            radioSmall.TabIndex = 4;
            radioSmall.TabStop = true;
            radioSmall.Text = "Küçük";
            radioSmall.UseVisualStyleBackColor = true;
            radioSmall.CheckedChanged += radioSmall_CheckedChanged;
            // 
            // radioMid
            // 
            radioMid.AutoSize = true;
            radioMid.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioMid.Location = new Point(151, 22);
            radioMid.Name = "radioMid";
            radioMid.Size = new Size(74, 34);
            radioMid.TabIndex = 5;
            radioMid.TabStop = true;
            radioMid.Text = "Orta";
            radioMid.UseVisualStyleBackColor = true;
            radioMid.CheckedChanged += radioMid_CheckedChanged;
            // 
            // radioKing
            // 
            radioKing.AutoSize = true;
            radioKing.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioKing.Location = new Point(286, 22);
            radioKing.Name = "radioKing";
            radioKing.Size = new Size(74, 34);
            radioKing.TabIndex = 6;
            radioKing.TabStop = true;
            radioKing.Text = "King";
            radioKing.UseVisualStyleBackColor = true;
            radioKing.CheckedChanged += radioKing_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioMid);
            groupBox1.Controls.Add(radioKing);
            groupBox1.Controls.Add(radioSmall);
            groupBox1.Location = new Point(36, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 66);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 396);
            label3.Name = "label3";
            label3.Size = new Size(219, 37);
            label3.TabIndex = 8;
            label3.Text = "Ekstra Malzeme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(121, 552);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 15;
            label4.Text = "Adet";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(187, 559);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(176, 588);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 17;
            button1.Text = "Siparis Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(456, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(407, 559);
            listBox1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(366, 588);
            label5.Name = "label5";
            label5.Size = new Size(142, 30);
            label5.TabIndex = 19;
            label5.Text = "Toplam Tutar";
            // 
            // PriaceLabel
            // 
            PriaceLabel.AutoSize = true;
            PriaceLabel.BackColor = SystemColors.Control;
            PriaceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PriaceLabel.ForeColor = SystemColors.Desktop;
            PriaceLabel.Location = new Point(514, 588);
            PriaceLabel.Name = "PriaceLabel";
            PriaceLabel.Size = new Size(55, 30);
            PriaceLabel.TabIndex = 20;
            PriaceLabel.Text = "0.00";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(631, 579);
            button2.Name = "button2";
            button2.Size = new Size(184, 49);
            button2.TabIndex = 21;
            button2.Text = "Siparis Tamamla";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkedListMalzeme
            // 
            checkedListMalzeme.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkedListMalzeme.FormattingEnabled = true;
            checkedListMalzeme.Location = new Point(36, 436);
            checkedListMalzeme.Name = "checkedListMalzeme";
            checkedListMalzeme.Size = new Size(390, 100);
            checkedListMalzeme.TabIndex = 22;
            checkedListMalzeme.ItemCheck += checkedListMalzeme_ItemCheck;
            // 
            // ToplamMalzemeFiyati
            // 
            ToplamMalzemeFiyati.AutoSize = true;
            ToplamMalzemeFiyati.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ToplamMalzemeFiyati.Location = new Point(251, 402);
            ToplamMalzemeFiyati.Name = "ToplamMalzemeFiyati";
            ToplamMalzemeFiyati.Size = new Size(25, 30);
            ToplamMalzemeFiyati.TabIndex = 23;
            ToplamMalzemeFiyati.Text = "0";
            // 
            // Hesapla
            // 
            Hesapla.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Hesapla.Location = new Point(12, 588);
            Hesapla.Name = "Hesapla";
            Hesapla.Size = new Size(151, 49);
            Hesapla.TabIndex = 24;
            Hesapla.Text = "Fiyat Hesapla";
            Hesapla.UseVisualStyleBackColor = true;
            Hesapla.Click += Hesapla_Click;
            // 
            // SiparisEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1010, 676);
            Controls.Add(Hesapla);
            Controls.Add(ToplamMalzemeFiyati);
            Controls.Add(checkedListMalzeme);
            Controls.Add(button2);
            Controls.Add(PriaceLabel);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(comboBoxMenu);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SiparisEkle";
            Opacity = 0.5D;
            Text = "SiparisEkle";
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
        private ComboBox comboBoxMenu;
        private Label label2;
        private RadioButton radioSmall;
        private RadioButton radioMid;
        private RadioButton radioKing;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private ListBox listBox1;
        private Label label5;
        private Label PriaceLabel;
        private Button button2;
        private CheckedListBox checkedListMalzeme;
        private Label ToplamMalzemeFiyati;
        private Button Hesapla;
    }
}