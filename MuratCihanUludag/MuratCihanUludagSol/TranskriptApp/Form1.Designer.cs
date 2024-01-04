namespace TranskriptApp
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            ogrenciYonetimiToolStripMenuItem = new ToolStripMenuItem();
            ogrenciIslemleriToolStripMenuItem = new ToolStripMenuItem();
            dersYonetimiToolStripMenuItem = new ToolStripMenuItem();
            dersEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciYonetimiToolStripMenuItem, dersYonetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciYonetimiToolStripMenuItem
            // 
            ogrenciYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogrenciIslemleriToolStripMenuItem });
            ogrenciYonetimiToolStripMenuItem.Name = "ogrenciYonetimiToolStripMenuItem";
            ogrenciYonetimiToolStripMenuItem.Size = new Size(97, 20);
            ogrenciYonetimiToolStripMenuItem.Text = "Islem Yonetimi";
            // 
            // ogrenciIslemleriToolStripMenuItem
            // 
            ogrenciIslemleriToolStripMenuItem.Name = "ogrenciIslemleriToolStripMenuItem";
            ogrenciIslemleriToolStripMenuItem.Size = new Size(180, 22);
            ogrenciIslemleriToolStripMenuItem.Text = "Islemler";
            ogrenciIslemleriToolStripMenuItem.Click += ogrenciIslemleriToolStripMenuItem_Click;
            // 
            // dersYonetimiToolStripMenuItem
            // 
            dersYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dersEkleToolStripMenuItem });
            dersYonetimiToolStripMenuItem.Name = "dersYonetimiToolStripMenuItem";
            dersYonetimiToolStripMenuItem.Size = new Size(137, 20);
            dersYonetimiToolStripMenuItem.Text = "Ogrenci Ders Yonetimi";
            // 
            // dersEkleToolStripMenuItem
            // 
            dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            dersEkleToolStripMenuItem.Size = new Size(183, 22);
            dersEkleToolStripMenuItem.Text = "Ogrenci Ders Ekleme";
            dersEkleToolStripMenuItem.Click += dersEkleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "OgrApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ogrenciYonetimiToolStripMenuItem;
        private ToolStripMenuItem ogrenciIslemleriToolStripMenuItem;
        private ToolStripMenuItem dersYonetimiToolStripMenuItem;
        private ToolStripMenuItem dersEkleToolStripMenuItem;
    }
}