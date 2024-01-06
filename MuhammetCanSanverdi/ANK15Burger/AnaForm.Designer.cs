namespace ANK15Burger
{
    partial class AnaForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            siparisYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparisEklemeToolStripMenuItem = new ToolStripMenuItem();
            siparisBilgileriToolStripMenuItem = new ToolStripMenuItem();
            urunYonetimiToolStripMenuItem = new ToolStripMenuItem();
            menuEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparisYönetimiToolStripMenuItem, urunYonetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1043, 35);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparisYönetimiToolStripMenuItem
            // 
            siparisYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparisEklemeToolStripMenuItem, siparisBilgileriToolStripMenuItem });
            siparisYönetimiToolStripMenuItem.Name = "siparisYönetimiToolStripMenuItem";
            siparisYönetimiToolStripMenuItem.Size = new Size(153, 29);
            siparisYönetimiToolStripMenuItem.Text = "Siparis Yönetimi";
            siparisYönetimiToolStripMenuItem.Click += siparisYönetimiToolStripMenuItem_Click;
            // 
            // siparisEklemeToolStripMenuItem
            // 
            siparisEklemeToolStripMenuItem.Name = "siparisEklemeToolStripMenuItem";
            siparisEklemeToolStripMenuItem.Size = new Size(270, 34);
            siparisEklemeToolStripMenuItem.Text = "Siparis Ekleme";
            siparisEklemeToolStripMenuItem.Click += siparisEklemeToolStripMenuItem_Click;
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            siparisBilgileriToolStripMenuItem.Size = new Size(270, 34);
            siparisBilgileriToolStripMenuItem.Text = "Siparis Bilgileri";
            siparisBilgileriToolStripMenuItem.Click += siparisBilgileriToolStripMenuItem_Click;
            // 
            // urunYonetimiToolStripMenuItem
            // 
            urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            urunYonetimiToolStripMenuItem.Size = new Size(134, 29);
            urunYonetimiToolStripMenuItem.Text = "UrunYonetimi";
            // 
            // menuEkleToolStripMenuItem
            // 
            menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            menuEkleToolStripMenuItem.Size = new Size(273, 34);
            menuEkleToolStripMenuItem.Text = "Menu Ekle";
            menuEkleToolStripMenuItem.Click += menuEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(273, 34);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 923);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AnaForm";
            Text = "AnaForm";
            Load += AnaForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparisYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparisEklemeToolStripMenuItem;
        private ToolStripMenuItem siparisBilgileriToolStripMenuItem;
        private ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private ToolStripMenuItem menuEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}
