namespace Transcript
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OgrenciEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.DersEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.DonemEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.transcriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OgrenciTranscript = new System.Windows.Forms.ToolStripMenuItem();
            this.OgrenciDersEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleSilToolStripMenuItem,
            this.transcriptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciEkleSilToolStripMenuItem
            // 
            this.öğrenciEkleSilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OgrenciEkleSil,
            this.DersEkleSil,
            this.DonemEkleSil});
            this.öğrenciEkleSilToolStripMenuItem.Name = "öğrenciEkleSilToolStripMenuItem";
            this.öğrenciEkleSilToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.öğrenciEkleSilToolStripMenuItem.Text = "EkleSil";
            // 
            // OgrenciEkleSil
            // 
            this.OgrenciEkleSil.Name = "OgrenciEkleSil";
            this.OgrenciEkleSil.Size = new System.Drawing.Size(157, 22);
            this.OgrenciEkleSil.Text = "Öğrenci Ekle/Sil";
            this.OgrenciEkleSil.Click += new System.EventHandler(this.OgrenciEkleSil_Click);
            // 
            // DersEkleSil
            // 
            this.DersEkleSil.Name = "DersEkleSil";
            this.DersEkleSil.Size = new System.Drawing.Size(157, 22);
            this.DersEkleSil.Text = "Ders Ekle/Sil";
            this.DersEkleSil.Click += new System.EventHandler(this.DersEkleSil_Click);
            // 
            // DonemEkleSil
            // 
            this.DonemEkleSil.Name = "DonemEkleSil";
            this.DonemEkleSil.Size = new System.Drawing.Size(157, 22);
            this.DonemEkleSil.Text = "Dönem Ekle/Sil";
            this.DonemEkleSil.Click += new System.EventHandler(this.DonemEkleSil_Click);
            // 
            // transcriptToolStripMenuItem
            // 
            this.transcriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OgrenciTranscript,
            this.OgrenciDersEkle});
            this.transcriptToolStripMenuItem.Name = "transcriptToolStripMenuItem";
            this.transcriptToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.transcriptToolStripMenuItem.Text = "Transcript";
            // 
            // OgrenciTranscript
            // 
            this.OgrenciTranscript.Name = "OgrenciTranscript";
            this.OgrenciTranscript.Size = new System.Drawing.Size(183, 22);
            this.OgrenciTranscript.Text = "Öğrenci-Transcript";
            this.OgrenciTranscript.Click += new System.EventHandler(this.OgrenciTranscript_Click);
            // 
            // OgrenciDersEkle
            // 
            this.OgrenciDersEkle.Name = "OgrenciDersEkle";
            this.OgrenciDersEkle.Size = new System.Drawing.Size(183, 22);
            this.OgrenciDersEkle.Text = "Öğrenci Ders Ekle-Sil";
            this.OgrenciDersEkle.Click += new System.EventHandler(this.OgrenciDersEkle_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrenciEkleSilToolStripMenuItem;
        private ToolStripMenuItem OgrenciEkleSil;
        private ToolStripMenuItem DersEkleSil;
        private ToolStripMenuItem DonemEkleSil;
        private ToolStripMenuItem transcriptToolStripMenuItem;
        private ToolStripMenuItem OgrenciTranscript;
        private ToolStripMenuItem OgrenciDersEkle;
    }
}