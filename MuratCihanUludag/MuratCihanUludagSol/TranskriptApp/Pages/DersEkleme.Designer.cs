namespace TranskriptApp.Pages
{
    partial class DersEkleme
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
            label1 = new Label();
            comboBoxOgr = new ComboBox();
            comboBoxDers = new ComboBox();
            label2 = new Label();
            comboBoxDonem = new ComboBox();
            label3 = new Label();
            comboBoxHarfNot = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci:";
            // 
            // comboBoxOgr
            // 
            comboBoxOgr.FormattingEnabled = true;
            comboBoxOgr.Location = new Point(93, 90);
            comboBoxOgr.Name = "comboBoxOgr";
            comboBoxOgr.Size = new Size(121, 23);
            comboBoxOgr.TabIndex = 1;
            // 
            // comboBoxDers
            // 
            comboBoxDers.FormattingEnabled = true;
            comboBoxDers.Location = new Point(273, 90);
            comboBoxDers.Name = "comboBoxDers";
            comboBoxDers.Size = new Size(121, 23);
            comboBoxDers.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(220, 94);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 2;
            label2.Text = "Ders:";
            // 
            // comboBoxDonem
            // 
            comboBoxDonem.FormattingEnabled = true;
            comboBoxDonem.Location = new Point(468, 90);
            comboBoxDonem.Name = "comboBoxDonem";
            comboBoxDonem.Size = new Size(121, 23);
            comboBoxDonem.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(400, 94);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 4;
            label3.Text = "Donem:";
            // 
            // comboBoxHarfNot
            // 
            comboBoxHarfNot.FormattingEnabled = true;
            comboBoxHarfNot.Location = new Point(687, 90);
            comboBoxHarfNot.Name = "comboBoxHarfNot";
            comboBoxHarfNot.Size = new Size(121, 23);
            comboBoxHarfNot.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(599, 94);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 6;
            label4.Text = "Harf Notu:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(788, 161);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(86, 346);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 9;
            button1.Text = "Ogrenciye Ders Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(246, 346);
            button2.Name = "button2";
            button2.Size = new Size(148, 46);
            button2.TabIndex = 10;
            button2.Text = "Ogrenciden Ders Cikar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(415, 346);
            button3.Name = "button3";
            button3.Size = new Size(128, 46);
            button3.TabIndex = 11;
            button3.Text = "Transcript Gor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DersEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxHarfNot);
            Controls.Add(label4);
            Controls.Add(comboBoxDonem);
            Controls.Add(label3);
            Controls.Add(comboBoxDers);
            Controls.Add(label2);
            Controls.Add(comboBoxOgr);
            Controls.Add(label1);
            Name = "DersEkleme";
            Text = "DersIslemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxOgr;
        private ComboBox comboBoxDers;
        private Label label2;
        private ComboBox comboBoxDonem;
        private Label label3;
        private ComboBox comboBoxHarfNot;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}