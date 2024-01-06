namespace ANK15TRANSKRİPT
{
    partial class TranskriptGör
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
            dataGridView1 = new DataGridView();
            cbxDonem = new ComboBox();
            label2 = new Label();
            cbxOgrenci = new ComboBox();
            label1 = new Label();
            btnTranskriptGoster = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(810, 316);
            dataGridView1.TabIndex = 13;
            // 
            // cbxDonem
            // 
            cbxDonem.FormattingEnabled = true;
            cbxDonem.Location = new Point(390, 35);
            cbxDonem.Name = "cbxDonem";
            cbxDonem.Size = new Size(182, 33);
            cbxDonem.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 43);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 11;
            label2.Text = "Dönem :";
            // 
            // cbxOgrenci
            // 
            cbxOgrenci.FormattingEnabled = true;
            cbxOgrenci.Location = new Point(102, 43);
            cbxOgrenci.Name = "cbxOgrenci";
            cbxOgrenci.Size = new Size(182, 33);
            cbxOgrenci.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 9;
            label1.Text = "Öğrenci :";
            // 
            // btnTranskriptGoster
            // 
            btnTranskriptGoster.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTranskriptGoster.Location = new Point(625, 27);
            btnTranskriptGoster.Name = "btnTranskriptGoster";
            btnTranskriptGoster.Size = new Size(198, 63);
            btnTranskriptGoster.TabIndex = 14;
            btnTranskriptGoster.Text = "Göster";
            btnTranskriptGoster.UseVisualStyleBackColor = true;
            // 
            // TranskriptGör
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 532);
            Controls.Add(btnTranskriptGoster);
            Controls.Add(dataGridView1);
            Controls.Add(cbxDonem);
            Controls.Add(label2);
            Controls.Add(cbxOgrenci);
            Controls.Add(label1);
            Name = "TranskriptGör";
            Text = "TranskriptGör";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cbxDonem;
        private Label label2;
        private ComboBox cbxOgrenci;
        private Label label1;
        private Button btnTranskriptGoster;
    }
}