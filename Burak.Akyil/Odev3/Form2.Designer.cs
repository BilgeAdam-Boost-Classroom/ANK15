namespace Odev3
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
            btnTamam = new Button();
            btnIptal = new Button();
            cbxRenk = new ComboBox();
            SuspendLayout();
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(12, 71);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(116, 39);
            btnTamam.TabIndex = 0;
            btnTamam.Text = "TAMAM";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(151, 71);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(108, 39);
            btnIptal.TabIndex = 0;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // cbxRenk
            // 
            cbxRenk.FormattingEnabled = true;
            cbxRenk.Location = new Point(12, 28);
            cbxRenk.Name = "cbxRenk";
            cbxRenk.Size = new Size(247, 23);
            cbxRenk.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 142);
            Controls.Add(cbxRenk);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTamam;
        private Button btnIptal;
        private ComboBox cbxRenk;
    }
}