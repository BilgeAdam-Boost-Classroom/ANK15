namespace calisan_bilgileri
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
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnÖnceki = new System.Windows.Forms.Button();
            this.btnGöster = new System.Windows.Forms.Button();
            this.lblGörünen = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "T.C";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(124, 34);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(106, 23);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(124, 66);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(106, 23);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(124, 94);
            this.txtYas.Margin = new System.Windows.Forms.Padding(2);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(106, 23);
            this.txtYas.TabIndex = 2;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(124, 127);
            this.txtTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(106, 23);
            this.txtTC.TabIndex = 3;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(118, 172);
            this.btnCalisanEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(111, 29);
            this.btnCalisanEkle.TabIndex = 4;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSonraki);
            this.groupBox1.Controls.Add(this.btnÖnceki);
            this.groupBox1.Controls.Add(this.btnGöster);
            this.groupBox1.Controls.Add(this.lblGörünen);
            this.groupBox1.Location = new System.Drawing.Point(275, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GÖRÜNTÜLENİN";
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(149, 186);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(30, 32);
            this.btnSonraki.TabIndex = 3;
            this.btnSonraki.Text = ">";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnÖnceki
            // 
            this.btnÖnceki.Location = new System.Drawing.Point(10, 186);
            this.btnÖnceki.Name = "btnÖnceki";
            this.btnÖnceki.Size = new System.Drawing.Size(30, 32);
            this.btnÖnceki.TabIndex = 2;
            this.btnÖnceki.Text = "<";
            this.btnÖnceki.UseVisualStyleBackColor = true;
            this.btnÖnceki.Click += new System.EventHandler(this.btnÖnceki_Click);
            // 
            // btnGöster
            // 
            this.btnGöster.Location = new System.Drawing.Point(10, 153);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(169, 23);
            this.btnGöster.TabIndex = 1;
            this.btnGöster.Text = "GÖSTER";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // lblGörünen
            // 
            this.lblGörünen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGörünen.Location = new System.Drawing.Point(10, 23);
            this.lblGörünen.Name = "lblGörünen";
            this.lblGörünen.Size = new System.Drawing.Size(169, 112);
            this.lblGörünen.TabIndex = 0;
            this.lblGörünen.Click += new System.EventHandler(this.lblGörünen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(15, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 184);
            this.listBox1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(545, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 221);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private Button btnCalisanEkle;
        private GroupBox groupBox1;
        private Button btnSonraki;
        private Button btnÖnceki;
        private Button btnGöster;
        private Label lblGörünen;
        private ListBox listBox1;
        private GroupBox groupBox2;
    }
}