namespace Odev3Renk
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
            cmRenk = new ComboBox();
            btnTamam = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // cmRenk
            // 
            cmRenk.FormattingEnabled = true;
            cmRenk.Location = new Point(93, 91);
            cmRenk.Name = "cmRenk";
            cmRenk.Size = new Size(423, 28);
            cmRenk.TabIndex = 0;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(148, 161);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(137, 56);
            btnTamam.TabIndex = 1;
            btnTamam.Text = "TAMAM";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(331, 161);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(137, 56);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 347);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Controls.Add(cmRenk);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmRenk;
        private Button btnTamam;
        private Button btnIptal;
    }
}