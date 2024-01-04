namespace ANK15Okul
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvDiplomalar = new System.Windows.Forms.DataGridView();
            this.lblSecilenDiploma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiplomalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diploma No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diploma Tarih:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(149, 30);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(138, 23);
            this.txtNo.TabIndex = 2;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(149, 70);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(138, 23);
            this.txtTarih.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(50, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(53, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(130, 117);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(76, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(234, 117);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(53, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvDiplomalar
            // 
            this.dgvDiplomalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiplomalar.Location = new System.Drawing.Point(50, 161);
            this.dgvDiplomalar.Name = "dgvDiplomalar";
            this.dgvDiplomalar.RowTemplate.Height = 25;
            this.dgvDiplomalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiplomalar.Size = new System.Drawing.Size(249, 263);
            this.dgvDiplomalar.TabIndex = 7;
            this.dgvDiplomalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiplomalar_CellClick);
            // 
            // lblSecilenDiploma
            // 
            this.lblSecilenDiploma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenDiploma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecilenDiploma.Location = new System.Drawing.Point(50, 427);
            this.lblSecilenDiploma.Name = "lblSecilenDiploma";
            this.lblSecilenDiploma.Size = new System.Drawing.Size(249, 38);
            this.lblSecilenDiploma.TabIndex = 8;
            this.lblSecilenDiploma.Text = "Secilen Diploma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.lblSecilenDiploma);
            this.Controls.Add(this.dgvDiplomalar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiplomalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNo;
        private TextBox txtTarih;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvDiplomalar;
        private Label lblSecilenDiploma;
    }
}