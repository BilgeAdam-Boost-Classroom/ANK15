namespace UniversiteDBUygulama
{
    partial class OgrenciForm
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
            label1 = new Label();
            label2 = new Label();
            cbxOgrenci = new ComboBox();
            cbxDanisman = new ComboBox();
            btnDanismanAta = new Button();
            lblDanisman = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 77);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 77);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Danışman:";
            // 
            // cbxOgrenci
            // 
            cbxOgrenci.FormattingEnabled = true;
            cbxOgrenci.Location = new Point(179, 74);
            cbxOgrenci.Name = "cbxOgrenci";
            cbxOgrenci.Size = new Size(121, 23);
            cbxOgrenci.TabIndex = 1;
            cbxOgrenci.SelectedIndexChanged += cbxOgrenci_SelectedIndexChanged;
            // 
            // cbxDanisman
            // 
            cbxDanisman.FormattingEnabled = true;
            cbxDanisman.Location = new Point(420, 74);
            cbxDanisman.Name = "cbxDanisman";
            cbxDanisman.Size = new Size(121, 23);
            cbxDanisman.TabIndex = 2;
            cbxDanisman.SelectedIndexChanged += cbxDanisman_SelectedIndexChanged;
            // 
            // btnDanismanAta
            // 
            btnDanismanAta.Location = new Point(236, 136);
            btnDanismanAta.Name = "btnDanismanAta";
            btnDanismanAta.Size = new Size(200, 42);
            btnDanismanAta.TabIndex = 3;
            btnDanismanAta.Text = "Danışman Ata";
            btnDanismanAta.UseVisualStyleBackColor = true;
            btnDanismanAta.Click += btnDanismanAta_Click;
            // 
            // lblDanisman
            // 
            lblDanisman.AutoSize = true;
            lblDanisman.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanisman.Location = new Point(236, 256);
            lblDanisman.Name = "lblDanisman";
            lblDanisman.Size = new Size(57, 21);
            lblDanisman.TabIndex = 4;
            lblDanisman.Text = "label3";
            // 
            // OgrenciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDanisman);
            Controls.Add(btnDanismanAta);
            Controls.Add(cbxDanisman);
            Controls.Add(cbxOgrenci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciForm";
            Text = "OgrenciForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDanisman;
        private Button btnDanismanAta;
        private Label lblDanisman;
    }
}