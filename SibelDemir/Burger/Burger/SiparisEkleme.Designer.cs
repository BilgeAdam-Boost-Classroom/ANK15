namespace Burger
{
    partial class SiparisEkleme
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
            groupBox1 = new GroupBox();
            btnMenuKaydet = new Button();
            numericUpDown1 = new NumericUpDown();
            textMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenuKaydet);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textMenuAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuKaydet
            // 
            btnMenuKaydet.Location = new Point(152, 157);
            btnMenuKaydet.Name = "btnMenuKaydet";
            btnMenuKaydet.Size = new Size(185, 76);
            btnMenuKaydet.TabIndex = 4;
            btnMenuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuKaydet.UseVisualStyleBackColor = true;
            btnMenuKaydet.Click += btnMenuKaydet_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(190, 39);
            numericUpDown1.TabIndex = 3;
            // 
            // textMenuAdi
            // 
            textMenuAdi.Location = new Point(147, 44);
            textMenuAdi.Name = "textMenuAdi";
            textMenuAdi.Size = new Size(190, 39);
            textMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı:";
            // 
            // SiparisEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 303);
            Controls.Add(groupBox1);
            Name = "SiparisEkleme";
            Text = "SiparisEkleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnMenuKaydet;
        private NumericUpDown numericUpDown1;
        private TextBox textMenuAdi;
    }
}