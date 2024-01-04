namespace TranskriptApp.Pages
{
    partial class Islemler
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButtonDers = new RadioButton();
            radioButtonDonem = new RadioButton();
            radioButtonOgr = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(515, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(441, 488);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(13, 32);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(420, 488);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekle && Guncelle && Sil";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonDers);
            groupBox2.Controls.Add(radioButtonDonem);
            groupBox2.Controls.Add(radioButtonOgr);
            groupBox2.Location = new Point(39, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yapilacak Islem";
            // 
            // radioButtonDers
            // 
            radioButtonDers.AutoSize = true;
            radioButtonDers.Location = new Point(251, 41);
            radioButtonDers.Name = "radioButtonDers";
            radioButtonDers.Size = new Size(79, 19);
            radioButtonDers.TabIndex = 2;
            radioButtonDers.TabStop = true;
            radioButtonDers.Text = "Ders Islem";
            radioButtonDers.UseVisualStyleBackColor = true;
            // 
            // radioButtonDonem
            // 
            radioButtonDonem.AutoSize = true;
            radioButtonDonem.Location = new Point(128, 41);
            radioButtonDonem.Name = "radioButtonDonem";
            radioButtonDonem.Size = new Size(95, 19);
            radioButtonDonem.TabIndex = 1;
            radioButtonDonem.TabStop = true;
            radioButtonDonem.Text = "Donem Islem";
            radioButtonDonem.UseVisualStyleBackColor = true;
            // 
            // radioButtonOgr
            // 
            radioButtonOgr.AutoSize = true;
            radioButtonOgr.Location = new Point(10, 41);
            radioButtonOgr.Name = "radioButtonOgr";
            radioButtonOgr.Size = new Size(98, 19);
            radioButtonOgr.TabIndex = 0;
            radioButtonOgr.TabStop = true;
            radioButtonOgr.Text = "Ogrenci Islem";
            radioButtonOgr.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(182, 387);
            button3.Name = "button3";
            button3.Size = new Size(161, 28);
            button3.TabIndex = 7;
            button3.Text = "Guncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(268, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 6;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(182, 338);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(29, 295);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 3;
            label3.Text = "Ogrenci Numarasi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(47, 245);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 2;
            label2.Text = "Ogrenci Soyadi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(73, 206);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 1;
            label1.Text = "Ogrenci Adi:";
            // 
            // Islemler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 635);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Islemler";
            Text = "Islemler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButtonDers;
        private RadioButton radioButtonDonem;
        private RadioButton radioButtonOgr;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}