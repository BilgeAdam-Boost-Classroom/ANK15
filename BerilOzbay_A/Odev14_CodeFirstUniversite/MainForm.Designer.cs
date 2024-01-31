namespace CodeFirstUniversite
{
    partial class MainForm
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
            danismanEkraniToolStripMenuItem = new ToolStripMenuItem();
            diplomaEkraniToolStripMenuItem = new ToolStripMenuItem();
            dersEkraniToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkraniToolStripMenuItem = new ToolStripMenuItem();
            ogrenciDersEkraniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danismanEkraniToolStripMenuItem, diplomaEkraniToolStripMenuItem, dersEkraniToolStripMenuItem, ogrenciEkraniToolStripMenuItem, ogrenciDersEkraniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1023, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // danismanEkraniToolStripMenuItem
            // 
            danismanEkraniToolStripMenuItem.Name = "danismanEkraniToolStripMenuItem";
            danismanEkraniToolStripMenuItem.Size = new Size(133, 24);
            danismanEkraniToolStripMenuItem.Text = "Danisman Ekrani";
            danismanEkraniToolStripMenuItem.Click += danismanEkraniToolStripMenuItem_Click;
            // 
            // diplomaEkraniToolStripMenuItem
            // 
            diplomaEkraniToolStripMenuItem.Name = "diplomaEkraniToolStripMenuItem";
            diplomaEkraniToolStripMenuItem.Size = new Size(125, 24);
            diplomaEkraniToolStripMenuItem.Text = "Diploma Ekrani";
            diplomaEkraniToolStripMenuItem.Click += diplomaEkraniToolStripMenuItem_Click;
            // 
            // dersEkraniToolStripMenuItem
            // 
            dersEkraniToolStripMenuItem.Name = "dersEkraniToolStripMenuItem";
            dersEkraniToolStripMenuItem.Size = new Size(97, 24);
            dersEkraniToolStripMenuItem.Text = "Ders Ekrani";
            dersEkraniToolStripMenuItem.Click += dersEkraniToolStripMenuItem_Click;
            // 
            // ogrenciEkraniToolStripMenuItem
            // 
            ogrenciEkraniToolStripMenuItem.Name = "ogrenciEkraniToolStripMenuItem";
            ogrenciEkraniToolStripMenuItem.Size = new Size(119, 24);
            ogrenciEkraniToolStripMenuItem.Text = "Ogrenci Ekrani";
            ogrenciEkraniToolStripMenuItem.Click += ogrenciEkraniToolStripMenuItem_Click;
            // 
            // ogrenciDersEkraniToolStripMenuItem
            // 
            ogrenciDersEkraniToolStripMenuItem.Name = "ogrenciDersEkraniToolStripMenuItem";
            ogrenciDersEkraniToolStripMenuItem.Size = new Size(153, 24);
            ogrenciDersEkraniToolStripMenuItem.Text = "Ogrenci Ders Ekrani";
            ogrenciDersEkraniToolStripMenuItem.Click += ogrenciDersEkraniToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 596);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danismanEkraniToolStripMenuItem;
        private ToolStripMenuItem diplomaEkraniToolStripMenuItem;
        private ToolStripMenuItem dersEkraniToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkraniToolStripMenuItem;
        private ToolStripMenuItem ogrenciDersEkraniToolStripMenuItem;
    }
}