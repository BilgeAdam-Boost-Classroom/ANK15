

namespace UniversiteUygulama
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            danismanEkraToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkranıToolStripMenuItem = new ToolStripMenuItem();
            diplomaEkranıToolStripMenuItem = new ToolStripMenuItem();
            dersEkranıToolStripMenuItem = new ToolStripMenuItem();
            ogrenciDersEkranıToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { danismanEkraToolStripMenuItem, ogrenciEkranıToolStripMenuItem, diplomaEkranıToolStripMenuItem, dersEkranıToolStripMenuItem, ogrenciDersEkranıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // danismanEkraToolStripMenuItem
            // 
            danismanEkraToolStripMenuItem.Name = "danismanEkraToolStripMenuItem";
            danismanEkraToolStripMenuItem.Size = new Size(159, 29);
            danismanEkraToolStripMenuItem.Text = "Danisman Ekranı";
            danismanEkraToolStripMenuItem.Click += danismanEkraToolStripMenuItem_Click;
            // 
            // ogrenciEkranıToolStripMenuItem
            // 
            ogrenciEkranıToolStripMenuItem.Name = "ogrenciEkranıToolStripMenuItem";
            ogrenciEkranıToolStripMenuItem.Size = new Size(142, 29);
            ogrenciEkranıToolStripMenuItem.Text = "Ogrenci Ekranı";
            ogrenciEkranıToolStripMenuItem.Click += ogrenciEkranıToolStripMenuItem_Click;
            // 
            // diplomaEkranıToolStripMenuItem
            // 
            diplomaEkranıToolStripMenuItem.Name = "diplomaEkranıToolStripMenuItem";
            diplomaEkranıToolStripMenuItem.Size = new Size(16, 29);
            // 
            // dersEkranıToolStripMenuItem
            // 
            dersEkranıToolStripMenuItem.Name = "dersEkranıToolStripMenuItem";
            dersEkranıToolStripMenuItem.Size = new Size(116, 29);
            dersEkranıToolStripMenuItem.Text = "Ders Ekranı";
            dersEkranıToolStripMenuItem.Click += dersEkranıToolStripMenuItem_Click;
            // 
            // ogrenciDersEkranıToolStripMenuItem
            // 
            ogrenciDersEkranıToolStripMenuItem.Name = "ogrenciDersEkranıToolStripMenuItem";
            ogrenciDersEkranıToolStripMenuItem.Size = new Size(183, 29);
            ogrenciDersEkranıToolStripMenuItem.Text = "Ogrenci Ders Ekranı";
            ogrenciDersEkranıToolStripMenuItem.Click += ogrenciDersEkranıToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem danismanEkraToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkranıToolStripMenuItem;
        private ToolStripMenuItem diplomaEkranıToolStripMenuItem;
        private ToolStripMenuItem dersEkranıToolStripMenuItem;
        private ToolStripMenuItem ogrenciDersEkranıToolStripMenuItem;
    }
}