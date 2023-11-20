namespace renkdegistirme
{
    partial class Form2
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
            this.cbxRenksecim = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxRenksecim
            // 
            this.cbxRenksecim.FormattingEnabled = true;
            this.cbxRenksecim.Location = new System.Drawing.Point(145, 68);
            this.cbxRenksecim.Name = "cbxRenksecim";
            this.cbxRenksecim.Size = new System.Drawing.Size(121, 21);
            this.cbxRenksecim.TabIndex = 0;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(135, 105);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(207, 105);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 2;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.cbxRenksecim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRenksecim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
    }
}