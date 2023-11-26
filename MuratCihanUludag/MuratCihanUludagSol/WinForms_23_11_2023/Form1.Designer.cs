namespace WinForms_23_11_2023
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
            label1 = new Label();
            listBox1 = new ListBox();
            Save = new Button();
            show = new Button();
            comboBoxCalisan = new ComboBox();
            comboBoxBirim = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 60);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Calisan Kisi:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(582, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 319);
            listBox1.TabIndex = 1;
            // 
            // Save
            // 
            Save.Location = new Point(206, 271);
            Save.Name = "Save";
            Save.Size = new Size(219, 64);
            Save.TabIndex = 2;
            Save.Text = "Kaydet";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // show
            // 
            show.Location = new Point(206, 365);
            show.Name = "show";
            show.Size = new Size(219, 64);
            show.TabIndex = 3;
            show.Text = "Goster";
            show.UseVisualStyleBackColor = true;
            show.Click += show_Click;
            // 
            // comboBoxCalisan
            // 
            comboBoxCalisan.FormattingEnabled = true;
            comboBoxCalisan.Location = new Point(157, 60);
            comboBoxCalisan.Name = "comboBoxCalisan";
            comboBoxCalisan.Size = new Size(376, 23);
            comboBoxCalisan.TabIndex = 4;
            // 
            // comboBoxBirim
            // 
            comboBoxBirim.FormattingEnabled = true;
            comboBoxBirim.Location = new Point(157, 168);
            comboBoxBirim.Name = "comboBoxBirim";
            comboBoxBirim.Size = new Size(376, 23);
            comboBoxBirim.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 168);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Birimi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxBirim);
            Controls.Add(label2);
            Controls.Add(comboBoxCalisan);
            Controls.Add(show);
            Controls.Add(Save);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button Save;
        private Button show;
        private ComboBox comboBoxCalisan;
        private ComboBox comboBoxBirim;
        private Label label2;
    }
}