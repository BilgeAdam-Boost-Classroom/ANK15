namespace FabrikaCodeFirst
{
    partial class MainForm
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
            plakaEkraniToolStripMenuItem = new ToolStripMenuItem();
            arabaEkraniToolStripMenuItem = new ToolStripMenuItem();
            kişiEkraniToolStripMenuItem = new ToolStripMenuItem();
            muhendisEkraniToolStripMenuItem = new ToolStripMenuItem();
            arabaMuhendisEkraniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plakaEkraniToolStripMenuItem, arabaEkraniToolStripMenuItem, kişiEkraniToolStripMenuItem, muhendisEkraniToolStripMenuItem, arabaMuhendisEkraniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(942, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // plakaEkraniToolStripMenuItem
            // 
            plakaEkraniToolStripMenuItem.Name = "plakaEkraniToolStripMenuItem";
            plakaEkraniToolStripMenuItem.Size = new Size(102, 24);
            plakaEkraniToolStripMenuItem.Text = "Plaka Ekrani";
            plakaEkraniToolStripMenuItem.Click += plakaEkraniToolStripMenuItem_Click;
            // 
            // arabaEkraniToolStripMenuItem
            // 
            arabaEkraniToolStripMenuItem.Name = "arabaEkraniToolStripMenuItem";
            arabaEkraniToolStripMenuItem.Size = new Size(107, 24);
            arabaEkraniToolStripMenuItem.Text = "Araba Ekrani";
            arabaEkraniToolStripMenuItem.Click += arabaEkraniToolStripMenuItem_Click;
            // 
            // kişiEkraniToolStripMenuItem
            // 
            kişiEkraniToolStripMenuItem.Name = "kişiEkraniToolStripMenuItem";
            kişiEkraniToolStripMenuItem.Size = new Size(90, 24);
            kişiEkraniToolStripMenuItem.Text = "Kişi Ekrani";
            kişiEkraniToolStripMenuItem.Click += kişiEkraniToolStripMenuItem_Click;
            // 
            // muhendisEkraniToolStripMenuItem
            // 
            muhendisEkraniToolStripMenuItem.Name = "muhendisEkraniToolStripMenuItem";
            muhendisEkraniToolStripMenuItem.Size = new Size(131, 24);
            muhendisEkraniToolStripMenuItem.Text = "Muhendis Ekrani";
            muhendisEkraniToolStripMenuItem.Click += muhendisEkraniToolStripMenuItem_Click;
            // 
            // arabaMuhendisEkraniToolStripMenuItem
            // 
            arabaMuhendisEkraniToolStripMenuItem.Name = "arabaMuhendisEkraniToolStripMenuItem";
            arabaMuhendisEkraniToolStripMenuItem.Size = new Size(175, 24);
            arabaMuhendisEkraniToolStripMenuItem.Text = "Araba Muhendis Ekrani";
            arabaMuhendisEkraniToolStripMenuItem.Click += arabaMuhendisEkraniToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 590);
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
        private ToolStripMenuItem plakaEkraniToolStripMenuItem;
        private ToolStripMenuItem arabaEkraniToolStripMenuItem;
        private ToolStripMenuItem kişiEkraniToolStripMenuItem;
        private ToolStripMenuItem muhendisEkraniToolStripMenuItem;
        private ToolStripMenuItem arabaMuhendisEkraniToolStripMenuItem;
    }
}