namespace UniversiteEF1
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
            danısmanToolStripMenuItem = new ToolStripMenuItem();
            ogrenciToolStripMenuItem = new ToolStripMenuItem();
            dersToolStripMenuItem = new ToolStripMenuItem();
            diplomaToolStripMenuItem = new ToolStripMenuItem();
            ogrenciyeDersToolStripMenuItem = new ToolStripMenuItem();
            ogrenciyeDanısmanToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { danısmanToolStripMenuItem, ogrenciToolStripMenuItem, dersToolStripMenuItem, diplomaToolStripMenuItem, ogrenciyeDersToolStripMenuItem, ogrenciyeDanısmanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1129, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // danısmanToolStripMenuItem
            // 
            danısmanToolStripMenuItem.Name = "danısmanToolStripMenuItem";
            danısmanToolStripMenuItem.Size = new Size(72, 20);
            danısmanToolStripMenuItem.Text = "Danısman";
            danısmanToolStripMenuItem.Click += danısmanToolStripMenuItem_Click;
            // 
            // ogrenciToolStripMenuItem
            // 
            ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            ogrenciToolStripMenuItem.Size = new Size(61, 20);
            ogrenciToolStripMenuItem.Text = "Ogrenci";
            ogrenciToolStripMenuItem.Click += ogrenciToolStripMenuItem_Click;
            // 
            // dersToolStripMenuItem
            // 
            dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            dersToolStripMenuItem.Size = new Size(42, 20);
            dersToolStripMenuItem.Text = "Ders";
            dersToolStripMenuItem.Click += dersToolStripMenuItem_Click;
            // 
            // diplomaToolStripMenuItem
            // 
            diplomaToolStripMenuItem.Name = "diplomaToolStripMenuItem";
            diplomaToolStripMenuItem.Size = new Size(64, 20);
            diplomaToolStripMenuItem.Text = "Diploma";
            diplomaToolStripMenuItem.Click += diplomaToolStripMenuItem_Click;
            // 
            // ogrenciyeDersToolStripMenuItem
            // 
            ogrenciyeDersToolStripMenuItem.Name = "ogrenciyeDersToolStripMenuItem";
            ogrenciyeDersToolStripMenuItem.Size = new Size(96, 20);
            ogrenciyeDersToolStripMenuItem.Text = "OgrenciyeDers";
            ogrenciyeDersToolStripMenuItem.Click += ogrenciyeDersToolStripMenuItem_Click;
            // 
            // ogrenciyeDanısmanToolStripMenuItem
            // 
            ogrenciyeDanısmanToolStripMenuItem.Name = "ogrenciyeDanısmanToolStripMenuItem";
            ogrenciyeDanısmanToolStripMenuItem.Size = new Size(126, 20);
            ogrenciyeDanısmanToolStripMenuItem.Text = "OgrenciyeDanısman";
            ogrenciyeDanısmanToolStripMenuItem.Click += ogrenciyeDanısmanToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 494);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AnaForm";
            Text = "AnaForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danısmanToolStripMenuItem;
        private ToolStripMenuItem ogrenciToolStripMenuItem;
        private ToolStripMenuItem dersToolStripMenuItem;
        private ToolStripMenuItem diplomaToolStripMenuItem;
        private ToolStripMenuItem ogrenciyeDersToolStripMenuItem;
        private ToolStripMenuItem ogrenciyeDanısmanToolStripMenuItem;
    }
}