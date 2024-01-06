namespace ANK15Burger
{
    partial class SiparisBilgileri
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
            listBox1 = new ListBox();
            label1 = new Label();
            label5 = new Label();
            lblCiro = new Label();
            lblTotalSiparis = new Label();
            label3 = new Label();
            lblÜrünAdedi = new Label();
            label6 = new Label();
            lblMalzemeGeliri = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(469, 454);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 36);
            label1.TabIndex = 1;
            label1.Text = "Tüm Siparişler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(534, 63);
            label5.Name = "label5";
            label5.Size = new Size(68, 38);
            label5.TabIndex = 5;
            label5.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiro.Location = new Point(544, 112);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(58, 32);
            lblCiro.TabIndex = 7;
            lblCiro.Text = "0,00";
            // 
            // lblTotalSiparis
            // 
            lblTotalSiparis.AutoSize = true;
            lblTotalSiparis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalSiparis.Location = new Point(544, 199);
            lblTotalSiparis.Name = "lblTotalSiparis";
            lblTotalSiparis.Size = new Size(27, 32);
            lblTotalSiparis.TabIndex = 9;
            lblTotalSiparis.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(534, 150);
            label3.Name = "label3";
            label3.Size = new Size(279, 38);
            label3.TabIndex = 8;
            label3.Text = "Toplam Sipariş Sayısı";
            // 
            // lblÜrünAdedi
            // 
            lblÜrünAdedi.AutoSize = true;
            lblÜrünAdedi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblÜrünAdedi.Location = new Point(544, 381);
            lblÜrünAdedi.Name = "lblÜrünAdedi";
            lblÜrünAdedi.Size = new Size(27, 32);
            lblÜrünAdedi.TabIndex = 13;
            lblÜrünAdedi.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(534, 332);
            label6.Name = "label6";
            label6.Size = new Size(255, 38);
            label6.TabIndex = 12;
            label6.Text = "Satılan Ürün Adedi";
            // 
            // lblMalzemeGeliri
            // 
            lblMalzemeGeliri.AutoSize = true;
            lblMalzemeGeliri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMalzemeGeliri.Location = new Point(544, 294);
            lblMalzemeGeliri.Name = "lblMalzemeGeliri";
            lblMalzemeGeliri.Size = new Size(58, 32);
            lblMalzemeGeliri.TabIndex = 11;
            lblMalzemeGeliri.Text = "0,00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(534, 245);
            label9.Name = "label9";
            label9.Size = new Size(292, 38);
            label9.TabIndex = 10;
            label9.Text = "Ekstra Malzeme Geliri";
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 657);
            Controls.Add(lblÜrünAdedi);
            Controls.Add(label6);
            Controls.Add(lblMalzemeGeliri);
            Controls.Add(label9);
            Controls.Add(lblTotalSiparis);
            Controls.Add(label3);
            Controls.Add(lblCiro);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            Load += SiparisBilgileri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label5;
        private Label lblCiro;
        private Label lblTotalSiparis;
        private Label label3;
        private Label lblÜrünAdedi;
        private Label label6;
        private Label lblMalzemeGeliri;
        private Label label9;
    }
}