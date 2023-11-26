namespace Odev6_Araba
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
            lbAraba = new ListBox();
            labelAraba = new Label();
            SuspendLayout();
            // 
            // lbAraba
            // 
            lbAraba.FormattingEnabled = true;
            lbAraba.ItemHeight = 20;
            lbAraba.Location = new Point(128, 24);
            lbAraba.Name = "lbAraba";
            lbAraba.Size = new Size(492, 224);
            lbAraba.TabIndex = 0;
            lbAraba.SelectedIndexChanged += lbAraba_SelectedIndexChanged;
            // 
            // labelAraba
            // 
            labelAraba.BorderStyle = BorderStyle.FixedSingle;
            labelAraba.Location = new Point(128, 292);
            labelAraba.Name = "labelAraba";
            labelAraba.Size = new Size(492, 122);
            labelAraba.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAraba);
            Controls.Add(lbAraba);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbAraba;
        private Label labelAraba;
    }
}