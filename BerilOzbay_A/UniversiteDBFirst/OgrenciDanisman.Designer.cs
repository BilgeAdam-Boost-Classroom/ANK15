namespace UniversiteDBFirst
{
    partial class OgrenciDanisman
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
            label3 = new Label();
            lblDanisman = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 97);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 97);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Danisman:";
            // 
            // cbxOgrenci
            // 
            cbxOgrenci.FormattingEnabled = true;
            cbxOgrenci.Location = new Point(186, 97);
            cbxOgrenci.Name = "cbxOgrenci";
            cbxOgrenci.Size = new Size(151, 28);
            cbxOgrenci.TabIndex = 2;
            cbxOgrenci.SelectedIndexChanged += cbxOgrenci_SelectedIndexChanged;
            // 
            // cbxDanisman
            // 
            cbxDanisman.FormattingEnabled = true;
            cbxDanisman.Location = new Point(475, 94);
            cbxDanisman.Name = "cbxDanisman";
            cbxDanisman.Size = new Size(151, 28);
            cbxDanisman.TabIndex = 3;
            // 
            // btnDanismanAta
            // 
            btnDanismanAta.Location = new Point(286, 154);
            btnDanismanAta.Name = "btnDanismanAta";
            btnDanismanAta.Size = new Size(183, 65);
            btnDanismanAta.TabIndex = 4;
            btnDanismanAta.Text = "Danisman Ata";
            btnDanismanAta.UseVisualStyleBackColor = true;
            btnDanismanAta.Click += btnDanismanAta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 256);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Danisman:";
            // 
            // lblDanisman
            // 
            lblDanisman.BorderStyle = BorderStyle.FixedSingle;
            lblDanisman.Location = new Point(270, 248);
            lblDanisman.Name = "lblDanisman";
            lblDanisman.Size = new Size(213, 28);
            lblDanisman.TabIndex = 6;
            // 
            // OgrenciDanisman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 348);
            Controls.Add(lblDanisman);
            Controls.Add(label3);
            Controls.Add(btnDanismanAta);
            Controls.Add(cbxDanisman);
            Controls.Add(cbxOgrenci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciDanisman";
            Text = "OgrenciDanisman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDanisman;
        private Button btnDanismanAta;
        private Label label3;
        private Label lblDanisman;
    }
}