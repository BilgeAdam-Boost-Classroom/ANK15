namespace Sınıf
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpCalisan = new System.Windows.Forms.GroupBox();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnGosterilen = new System.Windows.Forms.Button();
            this.lblGosterilen = new System.Windows.Forms.Label();
            this.ltbCalisan = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCalisan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "T.C:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(56, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(56, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(56, 103);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 23);
            this.txtYas.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(56, 137);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 23);
            this.txtTC.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çalışan Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCalisan
            // 
            this.grpCalisan.Controls.Add(this.btnOnceki);
            this.grpCalisan.Controls.Add(this.btnSonraki);
            this.grpCalisan.Controls.Add(this.btnGosterilen);
            this.grpCalisan.Controls.Add(this.lblGosterilen);
            this.grpCalisan.Location = new System.Drawing.Point(237, 30);
            this.grpCalisan.Name = "grpCalisan";
            this.grpCalisan.Size = new System.Drawing.Size(257, 286);
            this.grpCalisan.TabIndex = 3;
            this.grpCalisan.TabStop = false;
            this.grpCalisan.Text = "GÖRÜNTÜLENEN";
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(82, 199);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(32, 43);
            this.btnOnceki.TabIndex = 1;
            this.btnOnceki.Text = "<";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(142, 199);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(32, 43);
            this.btnSonraki.TabIndex = 1;
            this.btnSonraki.Text = ">";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnGosterilen
            // 
            this.btnGosterilen.Location = new System.Drawing.Point(29, 146);
            this.btnGosterilen.Name = "btnGosterilen";
            this.btnGosterilen.Size = new System.Drawing.Size(210, 35);
            this.btnGosterilen.TabIndex = 1;
            this.btnGosterilen.Text = "Göster";
            this.btnGosterilen.UseVisualStyleBackColor = true;
            this.btnGosterilen.Click += new System.EventHandler(this.btnGosterilen_Click);
            // 
            // lblGosterilen
            // 
            this.lblGosterilen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGosterilen.Location = new System.Drawing.Point(29, 33);
            this.lblGosterilen.Name = "lblGosterilen";
            this.lblGosterilen.Size = new System.Drawing.Size(210, 94);
            this.lblGosterilen.TabIndex = 0;
            // 
            // ltbCalisan
            // 
            this.ltbCalisan.FormattingEnabled = true;
            this.ltbCalisan.ItemHeight = 15;
            this.ltbCalisan.Location = new System.Drawing.Point(6, 22);
            this.ltbCalisan.Name = "ltbCalisan";
            this.ltbCalisan.Size = new System.Drawing.Size(188, 244);
            this.ltbCalisan.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ltbCalisan);
            this.groupBox1.Location = new System.Drawing.Point(544, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 283);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÜM ÇALIŞANLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCalisan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCalisan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private TextBox txtTC;
        private Button button1;
        private GroupBox grpCalisan;
        private Button btnOnceki;
        private Button btnSonraki;
        private Button btnGosterilen;
        private Label lblGosterilen;
        private ListBox ltbCalisan;
        private GroupBox groupBox1;
    }
}