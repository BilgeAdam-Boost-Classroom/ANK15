namespace BurgerMenu
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
            button1 = new Button();
            nudTutar = new NumericUpDown();
            label2 = new Label();
            txtEkstraMalzeme = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTutar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(nudTutar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEkstraMalzeme);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // button1
            // 
            button1.Location = new Point(131, 101);
            button1.Name = "button1";
            button1.Size = new Size(150, 43);
            button1.TabIndex = 4;
            button1.Text = "EKSTRA MALZEMEYİ KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nudTutar
            // 
            nudTutar.Location = new Point(131, 63);
            nudTutar.Name = "nudTutar";
            nudTutar.Size = new Size(150, 23);
            nudTutar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Fiyatı:";
            // 
            // txtEkstraMalzeme
            // 
            txtEkstraMalzeme.Location = new Point(131, 28);
            txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            txtEkstraMalzeme.Size = new Size(150, 23);
            txtEkstraMalzeme.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // EkstraMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 197);
            Controls.Add(groupBox1);
            Name = "EkstraMalzemeEkleme";
            Text = "EkstraMalzemeEkleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTutar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtEkstraMalzeme;
        private Button button1;
        private NumericUpDown nudTutar;
    }
}