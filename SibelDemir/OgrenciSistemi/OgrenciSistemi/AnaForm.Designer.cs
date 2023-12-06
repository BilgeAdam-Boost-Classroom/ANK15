namespace OgrenciSistemi
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
            ogrenciEkleSilGuncelleToolStripMenuItem = new ToolStripMenuItem();
            ogrenciToolStripMenuItem = new ToolStripMenuItem();
            dersEkraniToolStripMenuItem = new ToolStripMenuItem();
            donemEkraniToolStripMenuItem = new ToolStripMenuItem();
            dersEklemeToolStripMenuItem = new ToolStripMenuItem();
            transcriptGorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciEkleSilGuncelleToolStripMenuItem, dersEklemeToolStripMenuItem, transcriptGorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1416, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciEkleSilGuncelleToolStripMenuItem
            // 
            ogrenciEkleSilGuncelleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogrenciToolStripMenuItem, dersEkraniToolStripMenuItem, donemEkraniToolStripMenuItem });
            ogrenciEkleSilGuncelleToolStripMenuItem.Name = "ogrenciEkleSilGuncelleToolStripMenuItem";
            ogrenciEkleSilGuncelleToolStripMenuItem.Size = new Size(224, 29);
            ogrenciEkleSilGuncelleToolStripMenuItem.Text = "Ogrenci Ekle/Sil/Guncelle";
            // 
            // ogrenciToolStripMenuItem
            // 
            ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            ogrenciToolStripMenuItem.Size = new Size(228, 34);
            ogrenciToolStripMenuItem.Text = "Ogrenci Ekrani";
            ogrenciToolStripMenuItem.Click += ogrenciToolStripMenuItem_Click;
            // 
            // dersEkraniToolStripMenuItem
            // 
            dersEkraniToolStripMenuItem.Name = "dersEkraniToolStripMenuItem";
            dersEkraniToolStripMenuItem.Size = new Size(228, 34);
            dersEkraniToolStripMenuItem.Text = "Ders Ekrani";
            dersEkraniToolStripMenuItem.Click += dersEkraniToolStripMenuItem_Click;
            // 
            // donemEkraniToolStripMenuItem
            // 
            donemEkraniToolStripMenuItem.Name = "donemEkraniToolStripMenuItem";
            donemEkraniToolStripMenuItem.Size = new Size(228, 34);
            donemEkraniToolStripMenuItem.Text = "Donem Ekrani";
            donemEkraniToolStripMenuItem.Click += donemEkraniToolStripMenuItem_Click;
            // 
            // dersEklemeToolStripMenuItem
            // 
            dersEklemeToolStripMenuItem.Name = "dersEklemeToolStripMenuItem";
            dersEklemeToolStripMenuItem.Size = new Size(125, 29);
            dersEklemeToolStripMenuItem.Text = "Ders Ekleme";
            dersEklemeToolStripMenuItem.Click += dersEklemeToolStripMenuItem_Click;
            // 
            // transcriptGorToolStripMenuItem
            // 
            transcriptGorToolStripMenuItem.Name = "transcriptGorToolStripMenuItem";
            transcriptGorToolStripMenuItem.Size = new Size(103, 29);
            transcriptGorToolStripMenuItem.Text = "Transcript";
            transcriptGorToolStripMenuItem.Click += transcriptGorToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 910);
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
        private ToolStripMenuItem ogrenciEkleSilGuncelleToolStripMenuItem;
        private ToolStripMenuItem ogrenciToolStripMenuItem;
        private ToolStripMenuItem dersEkraniToolStripMenuItem;
        private ToolStripMenuItem donemEkraniToolStripMenuItem;
        private ToolStripMenuItem dersEklemeToolStripMenuItem;
        private ToolStripMenuItem transcriptGorToolStripMenuItem;
    }
}