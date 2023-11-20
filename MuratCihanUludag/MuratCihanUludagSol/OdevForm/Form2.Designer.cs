namespace OdevForm
{
    partial class Form2
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
            colorCombo = new ComboBox();
            success = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // colorCombo
            // 
            colorCombo.FormattingEnabled = true;
            colorCombo.Location = new Point(207, 112);
            colorCombo.Name = "colorCombo";
            colorCombo.Size = new Size(358, 23);
            colorCombo.TabIndex = 0;
            colorCombo.SelectedIndexChanged += colorCombo_SelectedIndexChanged;
            // 
            // success
            // 
            success.Location = new Point(207, 211);
            success.Name = "success";
            success.Size = new Size(99, 37);
            success.TabIndex = 1;
            success.Text = "Tamam";
            success.UseVisualStyleBackColor = true;
            success.Click += success_Click;
            // 
            // cancel
            // 
            cancel.BackColor = SystemColors.Control;
            cancel.Location = new Point(445, 211);
            cancel.Name = "cancel";
            cancel.Size = new Size(99, 37);
            cancel.TabIndex = 2;
            cancel.Text = "Iptal";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel);
            Controls.Add(success);
            Controls.Add(colorCombo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox colorCombo;
        private Button success;
        private Button cancel;
    }
}