namespace Ex03_01_2024
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
            label2 = new Label();
            txtNo = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dataGridDiploamalar = new DataGridView();
            dtTimeTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridDiploamalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Diploma No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Diploma Tarih:";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(158, 28);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(100, 23);
            txtNo.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(44, 134);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(56, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(121, 134);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(56, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(202, 134);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(56, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridDiploamalar
            // 
            dataGridDiploamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDiploamalar.Location = new Point(35, 215);
            dataGridDiploamalar.Name = "dataGridDiploamalar";
            dataGridDiploamalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDiploamalar.Size = new Size(223, 223);
            dataGridDiploamalar.TabIndex = 7;
            dataGridDiploamalar.CellClick += dataGridDiploamalar_CellClick;
            // 
            // dtTimeTarih
            // 
            dtTimeTarih.Location = new Point(158, 75);
            dtTimeTarih.Name = "dtTimeTarih";
            dtTimeTarih.Size = new Size(200, 23);
            dtTimeTarih.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtTimeTarih);
            Controls.Add(dataGridDiploamalar);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridDiploamalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dataGridDiploamalar;
        private DateTimePicker dtTimeTarih;
    }
}
