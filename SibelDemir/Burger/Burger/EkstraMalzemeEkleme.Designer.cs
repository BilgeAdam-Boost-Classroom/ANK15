namespace Burger
{
    partial class EkstraMalzemeEkleme
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
            numericUpDown1 = new NumericUpDown();
            textMalzemeAdi = new TextBox();
            btnMalzemeKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textMalzemeAdi);
            groupBox1.Controls.Add(btnMalzemeKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(262, 127);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 131072 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(223, 39);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // textMalzemeAdi
            // 
            textMalzemeAdi.Location = new Point(262, 61);
            textMalzemeAdi.Name = "textMalzemeAdi";
            textMalzemeAdi.Size = new Size(223, 39);
            textMalzemeAdi.TabIndex = 3;
            // 
            // btnMalzemeKaydet
            // 
            btnMalzemeKaydet.Location = new Point(113, 188);
            btnMalzemeKaydet.Name = "btnMalzemeKaydet";
            btnMalzemeKaydet.Size = new Size(257, 79);
            btnMalzemeKaydet.TabIndex = 2;
            btnMalzemeKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnMalzemeKaydet.UseVisualStyleBackColor = true;
            btnMalzemeKaydet.Click += btnMalzemeKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 127);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 61);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // EkstraMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 317);
            Controls.Add(groupBox1);
            Name = "EkstraMalzemeEkleme";
            Text = "EkstraMalzemeEkleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private TextBox textMalzemeAdi;
        private Button btnMalzemeKaydet;
    }
}