namespace EnumFormAlistirma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPersonel = new TextBox();
            cbDepartman = new ComboBox();
            btnPersonel = new Button();
            btnGoster = new Button();
            lbPersonelGoster = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 59);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "Lutfen Personel Adi giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 144);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 1;
            label2.Text = "Lutfen bir departman seciniz:";
            // 
            // txtPersonel
            // 
            txtPersonel.Location = new Point(160, 95);
            txtPersonel.Name = "txtPersonel";
            txtPersonel.Size = new Size(318, 27);
            txtPersonel.TabIndex = 2;
            // 
            // cbDepartman
            // 
            cbDepartman.FormattingEnabled = true;
            cbDepartman.Location = new Point(160, 191);
            cbDepartman.Name = "cbDepartman";
            cbDepartman.Size = new Size(318, 28);
            cbDepartman.TabIndex = 3;
            // 
            // btnPersonel
            // 
            btnPersonel.Location = new Point(160, 272);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(193, 29);
            btnPersonel.TabIndex = 4;
            btnPersonel.Text = "Personel Kaydet";
            btnPersonel.UseVisualStyleBackColor = true;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(160, 319);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(193, 29);
            btnGoster.TabIndex = 5;
            btnGoster.Text = "Goster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // lbPersonelGoster
            // 
            lbPersonelGoster.FormattingEnabled = true;
            lbPersonelGoster.ItemHeight = 20;
            lbPersonelGoster.Location = new Point(562, 59);
            lbPersonelGoster.Name = "lbPersonelGoster";
            lbPersonelGoster.Size = new Size(306, 304);
            lbPersonelGoster.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(lbPersonelGoster);
            Controls.Add(btnGoster);
            Controls.Add(btnPersonel);
            Controls.Add(cbDepartman);
            Controls.Add(txtPersonel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPersonel;
        private ComboBox cbDepartman;
        private Button btnPersonel;
        private Button btnGoster;
        private ListBox lbPersonelGoster;
    }
}