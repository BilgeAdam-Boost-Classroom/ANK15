namespace Odev_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.lbxCalisanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 55);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(95, 81);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(95, 107);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 0;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(95, 133);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(54, 58);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(54, 84);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(54, 106);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(31, 13);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yaş :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(54, 136);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(27, 13);
            this.lblTc.TabIndex = 4;
            this.lblTc.Text = "T.C.";
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(95, 170);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(100, 37);
            this.btnCalisanEkle.TabIndex = 5;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // lbxCalisanlar
            // 
            this.lbxCalisanlar.FormattingEnabled = true;
            this.lbxCalisanlar.Location = new System.Drawing.Point(256, 58);
            this.lbxCalisanlar.Name = "lbxCalisanlar";
            this.lbxCalisanlar.Size = new System.Drawing.Size(120, 95);
            this.lbxCalisanlar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxCalisanlar);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.ListBox lbxCalisanlar;
    }
}

