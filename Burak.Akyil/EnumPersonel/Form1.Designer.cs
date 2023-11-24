namespace EnumPersonel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDepartman = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lbxCalisanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Personel Adı Giriniz:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(248, 23);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen Bir Departman Seçiniz:";
            // 
            // cbxDepartman
            // 
            this.cbxDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartman.FormattingEnabled = true;
            this.cbxDepartman.Location = new System.Drawing.Point(12, 87);
            this.cbxDepartman.Name = "cbxDepartman";
            this.cbxDepartman.Size = new System.Drawing.Size(248, 23);
            this.cbxDepartman.TabIndex = 3;
            this.cbxDepartman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxDepartman_MouseClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(248, 37);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "PERSONEL KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(12, 179);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(248, 36);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lbxCalisanlar
            // 
            this.lbxCalisanlar.FormattingEnabled = true;
            this.lbxCalisanlar.ItemHeight = 15;
            this.lbxCalisanlar.Location = new System.Drawing.Point(326, 27);
            this.lbxCalisanlar.Name = "lbxCalisanlar";
            this.lbxCalisanlar.Size = new System.Drawing.Size(198, 184);
            this.lbxCalisanlar.TabIndex = 6;
            this.lbxCalisanlar.SelectedIndexChanged += new System.EventHandler(this.lbxCalisanlar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 240);
            this.Controls.Add(this.lbxCalisanlar);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbxDepartman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private ComboBox cbxDepartman;
        private Button btnKaydet;
        private Button btnGoster;
        private ListBox lbxCalisanlar;
    }
}