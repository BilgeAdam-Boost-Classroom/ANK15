
namespace ANK15SAYIBUL
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
            btnBaslat = new Button();
            buttonContainer = new GroupBox();
            button7 = new Button();
            button1 = new Button();
            button8 = new Button();
            button2 = new Button();
            button9 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            buttonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(325, 404);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(161, 67);
            btnBaslat.TabIndex = 9;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            // 
            // buttonContainer
            // 
            buttonContainer.Controls.Add(button7);
            buttonContainer.Controls.Add(button1);
            buttonContainer.Controls.Add(button8);
            buttonContainer.Controls.Add(button2);
            buttonContainer.Controls.Add(button9);
            buttonContainer.Controls.Add(button3);
            buttonContainer.Controls.Add(button4);
            buttonContainer.Controls.Add(button6);
            buttonContainer.Controls.Add(button5);
            buttonContainer.Location = new Point(29, 24);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(707, 355);
            buttonContainer.TabIndex = 10;
            buttonContainer.TabStop = false;
            buttonContainer.Text = "buttonContainer";
            buttonContainer.Enter += groupBox1_Enter;
            // 
            // button7
            // 
            button7.Location = new Point(412, 149);
            button7.Name = "button7";
            button7.Size = new Size(126, 72);
            button7.TabIndex = 19;
            button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(128, 51);
            button1.Name = "button1";
            button1.Size = new Size(113, 72);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(267, 149);
            button8.Name = "button8";
            button8.Size = new Size(115, 72);
            button8.TabIndex = 18;
            button8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(267, 51);
            button2.Name = "button2";
            button2.Size = new Size(115, 72);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(128, 149);
            button9.Name = "button9";
            button9.Size = new Size(113, 72);
            button9.TabIndex = 17;
            button9.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(412, 51);
            button3.Name = "button3";
            button3.Size = new Size(126, 72);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(412, 248);
            button4.Name = "button4";
            button4.Size = new Size(126, 72);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(128, 248);
            button6.Name = "button6";
            button6.Size = new Size(113, 72);
            button6.TabIndex = 14;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(267, 248);
            button5.Name = "button5";
            button5.Size = new Size(115, 72);
            button5.TabIndex = 15;
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 546);
            Controls.Add(buttonContainer);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            buttonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnBaslat;
        private GroupBox buttonContainer;
        private Button button7;
        private Button button1;
        private Button button8;
        private Button button2;
        private Button button9;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
    }
}
