namespace RandomButonOyunu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnBaslat = new Button();
            butonContainer = new GroupBox();
            butonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(107, 42);
            button1.Name = "button1";
            button1.Size = new Size(118, 76);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(261, 42);
            button2.Name = "button2";
            button2.Size = new Size(118, 76);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(437, 42);
            button3.Name = "button3";
            button3.Size = new Size(118, 76);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(437, 168);
            button4.Name = "button4";
            button4.Size = new Size(118, 76);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(261, 168);
            button5.Name = "button5";
            button5.Size = new Size(118, 76);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(107, 168);
            button6.Name = "button6";
            button6.Size = new Size(118, 76);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(437, 299);
            button7.Name = "button7";
            button7.Size = new Size(118, 76);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(261, 299);
            button8.Name = "button8";
            button8.Size = new Size(118, 76);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(107, 299);
            button9.Name = "button9";
            button9.Size = new Size(118, 76);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(554, 452);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(94, 29);
            btnBaslat.TabIndex = 9;
            btnBaslat.Text = "Baslat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // butonContainer
            // 
            butonContainer.Controls.Add(button9);
            butonContainer.Controls.Add(button6);
            butonContainer.Controls.Add(button7);
            butonContainer.Controls.Add(button8);
            butonContainer.Controls.Add(button1);
            butonContainer.Controls.Add(button4);
            butonContainer.Controls.Add(button2);
            butonContainer.Controls.Add(button5);
            butonContainer.Controls.Add(button3);
            butonContainer.Location = new Point(60, 12);
            butonContainer.Name = "butonContainer";
            butonContainer.Size = new Size(599, 420);
            butonContainer.TabIndex = 10;
            butonContainer.TabStop = false;
            butonContainer.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 532);
            Controls.Add(butonContainer);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            butonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnBaslat;
        private GroupBox butonContainer;
    }
}