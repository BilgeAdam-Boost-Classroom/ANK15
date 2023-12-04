namespace BurgerMenu
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
            groupBox1 = new GroupBox();
            lblCiro = new Label();
            groupBox2 = new GroupBox();
            lblToplamSiparis = new Label();
            groupBox3 = new GroupBox();
            lblEkstraMalzeme = new Label();
            groupBox4 = new GroupBox();
            lblSatılamUrun = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(196, 379);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiro);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(214, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 49);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Location = new Point(6, 19);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(0, 15);
            lblCiro.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblToplamSiparis);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(214, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Location = new Point(6, 19);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(0, 15);
            lblToplamSiparis.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEkstraMalzeme);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(214, 170);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 54);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzeme
            // 
            lblEkstraMalzeme.AutoSize = true;
            lblEkstraMalzeme.Location = new Point(6, 19);
            lblEkstraMalzeme.Name = "lblEkstraMalzeme";
            lblEkstraMalzeme.Size = new Size(0, 15);
            lblEkstraMalzeme.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSatılamUrun);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(214, 241);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 55);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatılamUrun
            // 
            lblSatılamUrun.AutoSize = true;
            lblSatılamUrun.Location = new Point(6, 19);
            lblSatılamUrun.Name = "lblSatılamUrun";
            lblSatılamUrun.Size = new Size(0, 15);
            lblSatılamUrun.TabIndex = 0;
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 424);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblCiro;
        private Label lblToplamSiparis;
        private Label lblEkstraMalzeme;
        private Label lblSatılamUrun;
    }
}