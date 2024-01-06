namespace ANK15SayiOyunu
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            txtBxSayi = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblUpOrDown = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(199, 150);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 0;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(199, 110);
            button2.Name = "button2";
            button2.Size = new Size(122, 34);
            button2.TabIndex = 1;
            button2.Text = "Tahmin Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(32, 207);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(474, 55);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // txtBxSayi
            // 
            txtBxSayi.Location = new Point(209, 66);
            txtBxSayi.Name = "txtBxSayi";
            txtBxSayi.Size = new Size(100, 23);
            txtBxSayi.TabIndex = 3;
            txtBxSayi.TextChanged += txtBxSayi_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 69);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Sayı : ";
            // 
            // timer1
            // 
            timer1.Interval = 60;
            // 
            // lblUpOrDown
            // 
            lblUpOrDown.AutoSize = true;
            lblUpOrDown.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpOrDown.Location = new Point(209, 295);
            lblUpOrDown.Name = "lblUpOrDown";
            lblUpOrDown.Size = new Size(0, 25);
            lblUpOrDown.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 364);
            Controls.Add(lblUpOrDown);
            Controls.Add(label1);
            Controls.Add(txtBxSayi);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ProgressBar progressBar1;
        private TextBox txtBxSayi;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label lblUpOrDown;
    }
}
