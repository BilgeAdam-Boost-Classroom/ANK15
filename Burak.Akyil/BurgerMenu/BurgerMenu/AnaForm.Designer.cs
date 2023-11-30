namespace BurgerMenu
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.EkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SiparisYonetimi,
            this.UrunYonetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SiparisYonetimi
            // 
            this.SiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SiparisEkle,
            this.SiparisBilgileri});
            this.SiparisYonetimi.Name = "SiparisYonetimi";
            this.SiparisYonetimi.Size = new System.Drawing.Size(106, 20);
            this.SiparisYonetimi.Text = " Sipariş Yönetimi";
            // 
            // SiparisEkle
            // 
            this.SiparisEkle.Name = "SiparisEkle";
            this.SiparisEkle.Size = new System.Drawing.Size(180, 22);
            this.SiparisEkle.Text = "Sipariş Ekle";
            this.SiparisEkle.Click += new System.EventHandler(this.SiparisEkle_Click);
            // 
            // SiparisBilgileri
            // 
            this.SiparisBilgileri.Name = "SiparisBilgileri";
            this.SiparisBilgileri.Size = new System.Drawing.Size(180, 22);
            this.SiparisBilgileri.Text = "Sipariş Bilgileri";
            this.SiparisBilgileri.Click += new System.EventHandler(this.SiparisBilgileri_Click);
            // 
            // UrunYonetimi
            // 
            this.UrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEkle,
            this.EkstraMalzemeEkle});
            this.UrunYonetimi.Name = "UrunYonetimi";
            this.UrunYonetimi.Size = new System.Drawing.Size(95, 20);
            this.UrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // MenuEkle
            // 
            this.MenuEkle.Name = "MenuEkle";
            this.MenuEkle.Size = new System.Drawing.Size(180, 22);
            this.MenuEkle.Text = "Menü Ekle";
            this.MenuEkle.Click += new System.EventHandler(this.MenuEkle_Click);
            // 
            // EkstraMalzemeEkle
            // 
            this.EkstraMalzemeEkle.Name = "EkstraMalzemeEkle";
            this.EkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.EkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.EkstraMalzemeEkle.Click += new System.EventHandler(this.EkstraMalzemeEkle_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem SiparisYonetimi;
        private ToolStripMenuItem SiparisEkle;
        private ToolStripMenuItem SiparisBilgileri;
        private ToolStripMenuItem UrunYonetimi;
        private ToolStripMenuItem MenuEkle;
        private ToolStripMenuItem EkstraMalzemeEkle;
    }
}