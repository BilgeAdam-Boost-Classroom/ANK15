namespace OdevForm
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
            ChangeColor = new Button();
            label1 = new Label();
            label2 = new Label();
            userName = new TextBox();
            password = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // ChangeColor
            // 
            ChangeColor.Location = new Point(45, 80);
            ChangeColor.Name = "ChangeColor";
            ChangeColor.Size = new Size(288, 221);
            ChangeColor.TabIndex = 0;
            ChangeColor.Text = "Renk Sec";
            ChangeColor.UseVisualStyleBackColor = true;
            ChangeColor.Click += ChangeColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 100);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Kulanici Adi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 132);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Sifre:";
            // 
            // userName
            // 
            userName.Location = new Point(550, 97);
            userName.Name = "userName";
            userName.Size = new Size(100, 23);
            userName.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(550, 132);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 4;
            // 
            // submit
            // 
            submit.Location = new Point(563, 197);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 5;
            submit.Text = "Giris Yap";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ChangeColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangeColor;
        private Label label1;
        private Label label2;
        private TextBox userName;
        private TextBox password;
        private Button submit;
    }
}