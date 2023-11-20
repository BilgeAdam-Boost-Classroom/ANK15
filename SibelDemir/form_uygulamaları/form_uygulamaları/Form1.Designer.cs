namespace form_uygulamaları
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
            btnRenkSeç = new Button();
            SuspendLayout();
            // 
            // btnRenkSeç
            // 
            btnRenkSeç.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnRenkSeç.FlatAppearance.BorderSize = 5;
            btnRenkSeç.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRenkSeç.Location = new Point(224, 72);
            btnRenkSeç.Name = "btnRenkSeç";
            btnRenkSeç.Size = new Size(374, 235);
            btnRenkSeç.TabIndex = 0;
            btnRenkSeç.Text = "RENK SEÇ";
            btnRenkSeç.UseVisualStyleBackColor = true;
            btnRenkSeç.Click += btnRenkSeç_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRenkSeç);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRenkSeç;
    }
}