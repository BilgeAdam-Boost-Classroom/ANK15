namespace UniversiteDBFirst.Models
{
    partial class Main
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
            danismanEkranİToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkraniToolStripMenuItem = new ToolStripMenuItem();
            danismanOgrenciEkraniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danismanEkranİToolStripMenuItem, ogrenciEkraniToolStripMenuItem, danismanOgrenciEkraniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1197, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danismanEkranİToolStripMenuItem
            // 
            danismanEkranİToolStripMenuItem.Name = "danismanEkranİToolStripMenuItem";
            danismanEkranİToolStripMenuItem.Size = new Size(133, 24);
            danismanEkranİToolStripMenuItem.Text = "Danisman Ekranİ";
            danismanEkranİToolStripMenuItem.Click += danismanEkranİToolStripMenuItem_Click;
            // 
            // ogrenciEkraniToolStripMenuItem
            // 
            ogrenciEkraniToolStripMenuItem.Name = "ogrenciEkraniToolStripMenuItem";
            ogrenciEkraniToolStripMenuItem.Size = new Size(119, 24);
            ogrenciEkraniToolStripMenuItem.Text = "Ogrenci Ekrani";
            ogrenciEkraniToolStripMenuItem.Click += ogrenciEkraniToolStripMenuItem_Click;
            // 
            // danismanOgrenciEkraniToolStripMenuItem
            // 
            danismanOgrenciEkraniToolStripMenuItem.Name = "danismanOgrenciEkraniToolStripMenuItem";
            danismanOgrenciEkraniToolStripMenuItem.Size = new Size(189, 24);
            danismanOgrenciEkraniToolStripMenuItem.Text = "Danisman Ogrenci Ekrani";
            danismanOgrenciEkraniToolStripMenuItem.Click += danismanOgrenciEkraniToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 604);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danismanEkranİToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkraniToolStripMenuItem;
        private ToolStripMenuItem danismanOgrenciEkraniToolStripMenuItem;
    }
}