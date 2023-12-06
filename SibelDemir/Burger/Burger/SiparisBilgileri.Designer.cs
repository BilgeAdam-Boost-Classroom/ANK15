namespace Burger
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
            lblToplamSiparisSayisi = new Label();
            groupBox3 = new GroupBox();
            lblEkstraGeliri = new Label();
            groupBox4 = new GroupBox();
            lblSatılanAdet = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(35, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(736, 629);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 1;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiro);
            groupBox1.Location = new Point(777, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 74);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(19, 27);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(56, 25);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "₺0,00";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblToplamSiparisSayisi);
            groupBox2.Location = new Point(777, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 68);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(19, 27);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(22, 25);
            lblToplamSiparisSayisi.TabIndex = 0;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEkstraGeliri);
            groupBox3.Location = new Point(777, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 67);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraGeliri
            // 
            lblEkstraGeliri.AutoSize = true;
            lblEkstraGeliri.ForeColor = Color.Red;
            lblEkstraGeliri.Location = new Point(19, 27);
            lblEkstraGeliri.Name = "lblEkstraGeliri";
            lblEkstraGeliri.Size = new Size(56, 25);
            lblEkstraGeliri.TabIndex = 0;
            lblEkstraGeliri.Text = "₺0,00";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSatılanAdet);
            groupBox4.Location = new Point(777, 350);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 71);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatılanAdet
            // 
            lblSatılanAdet.AutoSize = true;
            lblSatılanAdet.ForeColor = Color.Red;
            lblSatılanAdet.Location = new Point(19, 27);
            lblSatılanAdet.Name = "lblSatılanAdet";
            lblSatılanAdet.Size = new Size(22, 25);
            lblSatılanAdet.TabIndex = 0;
            lblSatılanAdet.Text = "0";
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 748);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            Load += SiparisBilgileri_Load;
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
        private Label lblToplamSiparisSayisi;
        private Label lblEkstraGeliri;
        private Label lblSatılanAdet;
    }
}