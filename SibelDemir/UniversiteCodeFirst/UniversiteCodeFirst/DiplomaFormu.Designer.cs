namespace UniversiteCodeFirst
{
    partial class DiplomaFormu
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
            txtTarih = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgwDiplomalar = new DataGridView();
            lblScilenDiploma = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwDiplomalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Diploma No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 112);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Diplıma Tarih:";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(187, 48);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(100, 23);
            txtNo.TabIndex = 2;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(187, 104);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(100, 23);
            txtTarih.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(46, 175);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(127, 175);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(212, 175);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dgwDiplomalar
            // 
            dgwDiplomalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDiplomalar.Location = new Point(46, 218);
            dgwDiplomalar.Name = "dgwDiplomalar";
            dgwDiplomalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDiplomalar.Size = new Size(241, 220);
            dgwDiplomalar.TabIndex = 7;
            dgwDiplomalar.CellClick += dgwDiplomalar_CellClick;
            // 
            // lblScilenDiploma
            // 
            lblScilenDiploma.BorderStyle = BorderStyle.FixedSingle;
            lblScilenDiploma.Location = new Point(369, 411);
            lblScilenDiploma.Name = "lblScilenDiploma";
            lblScilenDiploma.Size = new Size(267, 23);
            lblScilenDiploma.TabIndex = 8;
            lblScilenDiploma.Text = "Seçilen diploma:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScilenDiploma);
            Controls.Add(dgwDiplomalar);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtTarih);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwDiplomalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private TextBox txtTarih;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgwDiplomalar;
        private Label lblScilenDiploma;
    }
}
