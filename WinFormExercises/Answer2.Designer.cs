namespace WinFormExercises
{
    partial class Answer2
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
            txtnumber1 = new TextBox();
            txtnumber2 = new TextBox();
            btncalculate = new Button();
            label3 = new Label();
            lblsnc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Sayı 1 : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 90);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Sayı 2 : ";
            label2.Click += label2_Click;
            // 
            // txtnumber1
            // 
            txtnumber1.Location = new Point(208, 57);
            txtnumber1.Name = "txtnumber1";
            txtnumber1.Size = new Size(100, 23);
            txtnumber1.TabIndex = 2;
            txtnumber1.TextChanged += txtnumber1_TextChanged;
            // 
            // txtnumber2
            // 
            txtnumber2.Location = new Point(208, 82);
            txtnumber2.Name = "txtnumber2";
            txtnumber2.Size = new Size(100, 23);
            txtnumber2.TabIndex = 3;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(218, 111);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(79, 33);
            btncalculate.TabIndex = 4;
            btncalculate.Text = "Hesapla";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 160);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Sonuc : ";
            // 
            // lblsnc
            // 
            lblsnc.AutoSize = true;
            lblsnc.Location = new Point(219, 160);
            lblsnc.Name = "lblsnc";
            lblsnc.Size = new Size(0, 15);
            lblsnc.TabIndex = 6;
            // 
            // Answer2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 238);
            Controls.Add(lblsnc);
            Controls.Add(label3);
            Controls.Add(btncalculate);
            Controls.Add(txtnumber2);
            Controls.Add(txtnumber1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Answer2";
            Text = "Answer2";
            Load += Answer2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnumber1;
        private TextBox txtnumber2;
        private Button btncalculate;
        private Label label3;
        private Label lblsnc;
    }
}