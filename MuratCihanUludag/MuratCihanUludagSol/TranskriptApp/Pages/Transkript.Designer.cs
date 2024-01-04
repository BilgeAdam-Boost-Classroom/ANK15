namespace TranskriptApp.Pages
{
    partial class Transkript
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
            label2 = new Label();
            comboBoxOgr = new ComboBox();
            comboBoxDonem = new ComboBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toplamKredi = new Label();
            label7 = new Label();
            label8 = new Label();
            DonemOrtalama = new Label();
            GenelOrt = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Donem";
            // 
            // comboBoxOgr
            // 
            comboBoxOgr.FormattingEnabled = true;
            comboBoxOgr.Location = new Point(192, 57);
            comboBoxOgr.Name = "comboBoxOgr";
            comboBoxOgr.Size = new Size(121, 23);
            comboBoxOgr.TabIndex = 2;
            // 
            // comboBoxDonem
            // 
            comboBoxDonem.FormattingEnabled = true;
            comboBoxDonem.Location = new Point(458, 62);
            comboBoxDonem.Name = "comboBoxDonem";
            comboBoxDonem.Size = new Size(121, 23);
            comboBoxDonem.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(728, 187);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 337);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Donem Kredisi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 378);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Toplam Kredi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 337);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 7;
            label5.Text = "40";
            // 
            // toplamKredi
            // 
            toplamKredi.AutoSize = true;
            toplamKredi.Location = new Point(134, 378);
            toplamKredi.Name = "toplamKredi";
            toplamKredi.Size = new Size(0, 15);
            toplamKredi.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 337);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 9;
            label7.Text = "Donem Ortalamasi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(595, 378);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 10;
            label8.Text = "Genel Ortalama";
            // 
            // DonemOrtalama
            // 
            DonemOrtalama.AutoSize = true;
            DonemOrtalama.Location = new Point(705, 337);
            DonemOrtalama.Name = "DonemOrtalama";
            DonemOrtalama.Size = new Size(38, 15);
            DonemOrtalama.TabIndex = 11;
            DonemOrtalama.Text = "label9";
            // 
            // GenelOrt
            // 
            GenelOrt.AutoSize = true;
            GenelOrt.Location = new Point(699, 378);
            GenelOrt.Name = "GenelOrt";
            GenelOrt.Size = new Size(44, 15);
            GenelOrt.TabIndex = 12;
            GenelOrt.Text = "label10";
            // 
            // button1
            // 
            button1.Location = new Point(652, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Goster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Transkript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(GenelOrt);
            Controls.Add(DonemOrtalama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(toplamKredi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxDonem);
            Controls.Add(comboBoxOgr);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transkript";
            Text = "Transkript";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxOgr;
        private ComboBox comboBoxDonem;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label toplamKredi;
        private Label label7;
        private Label label8;
        private Label DonemOrtalama;
        private Label GenelOrt;
        private Button button1;
    }
}