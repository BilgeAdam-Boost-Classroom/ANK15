﻿namespace UniversiteDBUygulama
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
            danismanEkraniToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkraniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { danismanEkraniToolStripMenuItem, ogrenciEkraniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danismanEkraniToolStripMenuItem
            // 
            danismanEkraniToolStripMenuItem.Name = "danismanEkraniToolStripMenuItem";
            danismanEkraniToolStripMenuItem.Size = new Size(104, 20);
            danismanEkraniToolStripMenuItem.Text = "DanismanEkrani";
            danismanEkraniToolStripMenuItem.Click += danismanEkraniToolStripMenuItem_Click;
            // 
            // ogrenciEkraniToolStripMenuItem
            // 
            ogrenciEkraniToolStripMenuItem.Name = "ogrenciEkraniToolStripMenuItem";
            ogrenciEkraniToolStripMenuItem.Size = new Size(93, 20);
            ogrenciEkraniToolStripMenuItem.Text = "OgrenciEkrani";
            ogrenciEkraniToolStripMenuItem.Click += ogrenciEkraniToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            Text = "AnaForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danismanEkraniToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkraniToolStripMenuItem;
    }
}