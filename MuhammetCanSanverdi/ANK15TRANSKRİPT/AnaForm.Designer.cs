namespace ANK15TRANSKRİPT
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
            menuStrip1 = new MenuStrip();
            ogrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            dersEkleToolStripMenuItem = new ToolStripMenuItem();
            donemEkleToolStripMenuItem = new ToolStripMenuItem();
            ogrenciDersEkleToolStripMenuItem = new ToolStripMenuItem();
            transkriptGörToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciEkleToolStripMenuItem, dersEkleToolStripMenuItem, donemEkleToolStripMenuItem, ogrenciDersEkleToolStripMenuItem, transkriptGörToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1273, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            ogrenciEkleToolStripMenuItem.Size = new Size(126, 29);
            ogrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            ogrenciEkleToolStripMenuItem.Click += ogrenciEkleToolStripMenuItem_Click;
            // 
            // dersEkleToolStripMenuItem
            // 
            dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            dersEkleToolStripMenuItem.Size = new Size(100, 29);
            dersEkleToolStripMenuItem.Text = "Ders Ekle";
            dersEkleToolStripMenuItem.Click += dersEkleToolStripMenuItem_Click;
            // 
            // donemEkleToolStripMenuItem
            // 
            donemEkleToolStripMenuItem.Name = "donemEkleToolStripMenuItem";
            donemEkleToolStripMenuItem.Size = new Size(123, 29);
            donemEkleToolStripMenuItem.Text = "Dönem Ekle";
            donemEkleToolStripMenuItem.Click += donemEkleToolStripMenuItem_Click;
            // 
            // ogrenciDersEkleToolStripMenuItem
            // 
            ogrenciDersEkleToolStripMenuItem.Name = "ogrenciDersEkleToolStripMenuItem";
            ogrenciDersEkleToolStripMenuItem.Size = new Size(167, 29);
            ogrenciDersEkleToolStripMenuItem.Text = "Öğrenci Ders Ekle";
            ogrenciDersEkleToolStripMenuItem.Click += ogrenciDersEkleToolStripMenuItem_Click;
            // 
            // transkriptGörToolStripMenuItem
            // 
            transkriptGörToolStripMenuItem.Name = "transkriptGörToolStripMenuItem";
            transkriptGörToolStripMenuItem.Size = new Size(138, 29);
            transkriptGörToolStripMenuItem.Text = "Transkript Gör";
            transkriptGörToolStripMenuItem.Click += transkriptGörToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 786);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            Text = "AnaForm";
            Load += AnaForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private ToolStripMenuItem dersEkleToolStripMenuItem;
        private ToolStripMenuItem donemEkleToolStripMenuItem;
        private ToolStripMenuItem ogrenciDersEkleToolStripMenuItem;
        private ToolStripMenuItem transkriptGörToolStripMenuItem;
    }
}