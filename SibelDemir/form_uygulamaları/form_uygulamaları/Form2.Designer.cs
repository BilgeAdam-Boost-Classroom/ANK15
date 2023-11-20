namespace form_uygulamaları
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
            comboBox1 = new ComboBox();
            btnTamam = new Button();
            btnİptal = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AliceBlue", "Red", "Green", "Blue" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(416, 33);
            comboBox1.TabIndex = 0;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(27, 85);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(141, 86);
            btnTamam.TabIndex = 1;
            btnTamam.Text = "TAMAM";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(228, 85);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(150, 86);
            btnİptal.TabIndex = 2;
            btnİptal.Text = "İPTAL";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 263);
            Controls.Add(btnİptal);
            Controls.Add(btnTamam);
            Controls.Add(comboBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnTamam;
        private Button btnİptal;
    }
}