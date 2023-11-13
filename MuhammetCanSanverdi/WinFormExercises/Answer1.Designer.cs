namespace WinFormExercises
{
    partial class Answer1
    {/// <summary>
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
            txtA = new TextBox();
            txtC = new TextBox();
            txtB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            lblsnc = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(304, 61);
            txtA.Name = "txtA";
            txtA.Size = new Size(162, 23);
            txtA.TabIndex = 0;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // txtC
            // 
            txtC.Location = new Point(304, 119);
            txtC.Name = "txtC";
            txtC.Size = new Size(162, 23);
            txtC.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(304, 90);
            txtB.Name = "txtB";
            txtB.Size = new Size(162, 23);
            txtB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 64);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "A:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 93);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 4;
            label2.Text = "B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 122);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 5;
            label3.Text = "C:";
            // 
            // button1
            // 
            button1.Location = new Point(329, 161);
            button1.Name = "button1";
            button1.Size = new Size(99, 28);
            button1.TabIndex = 6;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 250);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "SONUC: ";
            label4.Click += label4_Click;
            // 
            // lblsnc
            // 
            lblsnc.AutoSize = true;
            lblsnc.Location = new Point(363, 250);
            lblsnc.Name = "lblsnc";
            lblsnc.Size = new Size(0, 15);
            lblsnc.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblsnc);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtC;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label lblsnc;
    }
}