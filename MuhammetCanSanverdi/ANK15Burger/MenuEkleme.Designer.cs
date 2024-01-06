namespace ANK15Burger
{
    partial class MenuEkleme
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
            btnMenuAdd = new Button();
            numUDMenuPrice = new NumericUpDown();
            txtbxMenuAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDMenuPrice).BeginInit();
            SuspendLayout();
            // 
            // btnMenuAdd
            // 
            btnMenuAdd.Location = new Point(83, 168);
            btnMenuAdd.Name = "btnMenuAdd";
            btnMenuAdd.Size = new Size(196, 86);
            btnMenuAdd.TabIndex = 12;
            btnMenuAdd.Text = "MENÜYÜ KAYDET";
            btnMenuAdd.UseVisualStyleBackColor = true;
            btnMenuAdd.Click += btnMenuAdd_Click;
            // 
            // numUDMenuPrice
            // 
            numUDMenuPrice.Location = new Point(83, 131);
            numUDMenuPrice.Name = "numUDMenuPrice";
            numUDMenuPrice.Size = new Size(150, 31);
            numUDMenuPrice.TabIndex = 11;
            // 
            // txtbxMenuAd
            // 
            txtbxMenuAd.Location = new Point(83, 81);
            txtbxMenuAd.Name = "txtbxMenuAd";
            txtbxMenuAd.Size = new Size(150, 31);
            txtbxMenuAd.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 131);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 9;
            label3.Text = "Fiyatı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 84);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 8;
            label2.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 7;
            label1.Text = "Menü Bilgileri";
            // 
            // MenuEkleme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 365);
            Controls.Add(btnMenuAdd);
            Controls.Add(numUDMenuPrice);
            Controls.Add(txtbxMenuAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuEkleme";
            Text = "MenuEkleme";
            ((System.ComponentModel.ISupportInitialize)numUDMenuPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuAdd;
        private NumericUpDown numUDMenuPrice;
        private TextBox txtbxMenuAd;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}