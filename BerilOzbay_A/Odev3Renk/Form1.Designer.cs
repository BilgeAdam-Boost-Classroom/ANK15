namespace Odev3Renk
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
            btnRenkDegistir = new Button();
            SuspendLayout();
            // 
            // btnRenkDegistir
            // 
            btnRenkDegistir.Location = new Point(183, 87);
            btnRenkDegistir.Name = "btnRenkDegistir";
            btnRenkDegistir.Size = new Size(304, 166);
            btnRenkDegistir.TabIndex = 0;
            btnRenkDegistir.Text = "RENK SEÇ";
            btnRenkDegistir.UseVisualStyleBackColor = true;
            btnRenkDegistir.Click += btnRenkDegistir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 360);
            Controls.Add(btnRenkDegistir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRenkDegistir;
    }
}