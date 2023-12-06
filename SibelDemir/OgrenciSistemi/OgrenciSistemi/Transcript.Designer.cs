namespace OgrenciSistemi
{
    partial class Transcript
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
            cmbxTOgrenci = new ComboBox();
            cmbxTDonem = new ComboBox();
            dataGridView1 = new DataGridView();
            btnGoster = new Button();
            label3 = new Label();
            label4 = new Label();
            lblDonemKredisi = new Label();
            lblToplamKredi = new Label();
            label7 = new Label();
            label8 = new Label();
            lblDonemOrt = new Label();
            lblGenelOrt = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 61);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Dönem:";
            // 
            // cmbxTOgrenci
            // 
            cmbxTOgrenci.FormattingEnabled = true;
            cmbxTOgrenci.Location = new Point(94, 58);
            cmbxTOgrenci.Name = "cmbxTOgrenci";
            cmbxTOgrenci.Size = new Size(182, 33);
            cmbxTOgrenci.TabIndex = 3;
            // 
            // cmbxTDonem
            // 
            cmbxTDonem.FormattingEnabled = true;
            cmbxTDonem.Location = new Point(384, 58);
            cmbxTDonem.Name = "cmbxTDonem";
            cmbxTDonem.Size = new Size(182, 33);
            cmbxTDonem.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(888, 225);
            dataGridView1.TabIndex = 6;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(626, 48);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(147, 51);
            btnGoster.TabIndex = 7;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 426);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 8;
            label3.Text = "Dönem Kredisi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 477);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 9;
            label4.Text = "Toplam Kredi:";
            // 
            // lblDonemKredisi
            // 
            lblDonemKredisi.AutoSize = true;
            lblDonemKredisi.Location = new Point(169, 426);
            lblDonemKredisi.Name = "lblDonemKredisi";
            lblDonemKredisi.Size = new Size(0, 25);
            lblDonemKredisi.TabIndex = 10;
            // 
            // lblToplamKredi
            // 
            lblToplamKredi.AutoSize = true;
            lblToplamKredi.Location = new Point(169, 477);
            lblToplamKredi.Name = "lblToplamKredi";
            lblToplamKredi.Size = new Size(0, 25);
            lblToplamKredi.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(685, 426);
            label7.Name = "label7";
            label7.Size = new Size(156, 25);
            label7.TabIndex = 12;
            label7.Text = "Dönem Ortalamsı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(685, 477);
            label8.Name = "label8";
            label8.Size = new Size(138, 25);
            label8.TabIndex = 13;
            label8.Text = "Genel Ortalama:";
            // 
            // lblDonemOrt
            // 
            lblDonemOrt.AutoSize = true;
            lblDonemOrt.Location = new Point(841, 435);
            lblDonemOrt.Name = "lblDonemOrt";
            lblDonemOrt.Size = new Size(0, 25);
            lblDonemOrt.TabIndex = 14;
            // 
            // lblGenelOrt
            // 
            lblGenelOrt.AutoSize = true;
            lblGenelOrt.Location = new Point(841, 477);
            lblGenelOrt.Name = "lblGenelOrt";
            lblGenelOrt.Size = new Size(0, 25);
            lblGenelOrt.TabIndex = 15;
            // 
            // Transcript
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 577);
            Controls.Add(lblGenelOrt);
            Controls.Add(lblDonemOrt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblToplamKredi);
            Controls.Add(lblDonemKredisi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnGoster);
            Controls.Add(dataGridView1);
            Controls.Add(cmbxTDonem);
            Controls.Add(cmbxTOgrenci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transcript";
            Text = "Transcript";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbxTOgrenci;
        private ComboBox cmbxTDonem;
        private DataGridView dataGridView1;
        private Button btnGoster;
        private Label label3;
        private Label label4;
        private Label lblDonemKredisi;
        private Label lblToplamKredi;
        private Label label7;
        private Label label8;
        private Label lblDonemOrt;
        private Label lblGenelOrt;
    }
}