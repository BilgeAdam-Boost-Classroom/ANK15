namespace ANK15Burger
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbxExMalzemeAd = new TextBox();
            numUDExMalzemePrice = new NumericUpDown();
            btnMalzemeAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numUDExMalzemePrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(288, 32);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 87);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 1;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Fiyatı";
            // 
            // txtbxExMalzemeAd
            // 
            txtbxExMalzemeAd.Location = new Point(95, 84);
            txtbxExMalzemeAd.Name = "txtbxExMalzemeAd";
            txtbxExMalzemeAd.Size = new Size(150, 31);
            txtbxExMalzemeAd.TabIndex = 4;
            // 
            // numUDExMalzemePrice
            // 
            numUDExMalzemePrice.Location = new Point(95, 134);
            numUDExMalzemePrice.Name = "numUDExMalzemePrice";
            numUDExMalzemePrice.Size = new Size(150, 31);
            numUDExMalzemePrice.TabIndex = 5;
            numUDExMalzemePrice.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnMalzemeAdd
            // 
            btnMalzemeAdd.Location = new Point(95, 171);
            btnMalzemeAdd.Name = "btnMalzemeAdd";
            btnMalzemeAdd.Size = new Size(196, 86);
            btnMalzemeAdd.TabIndex = 6;
            btnMalzemeAdd.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnMalzemeAdd.UseVisualStyleBackColor = true;
            btnMalzemeAdd.Click += btnMalzemeAdd_Click;
            // 
            // EkstraMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 320);
            Controls.Add(btnMalzemeAdd);
            Controls.Add(numUDExMalzemePrice);
            Controls.Add(txtbxExMalzemeAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EkstraMalzemeEkleme";
            Text = "EkstraMalzemeEkleme";
            ((System.ComponentModel.ISupportInitialize)numUDExMalzemePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbxExMalzemeAd;
        private NumericUpDown numUDExMalzemePrice;
        private Button btnMalzemeAdd;
    }
}