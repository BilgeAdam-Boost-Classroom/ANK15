namespace Transcript
{
    partial class DersEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.txtDersKod = new System.Windows.Forms.TextBox();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.dataGridDers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kredi:";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(76, 32);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(100, 23);
            this.txtDersAd.TabIndex = 3;
            // 
            // txtDersKod
            // 
            this.txtDersKod.Location = new System.Drawing.Point(76, 71);
            this.txtDersKod.Name = "txtDersKod";
            this.txtDersKod.Size = new System.Drawing.Size(100, 23);
            this.txtDersKod.TabIndex = 4;
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(76, 104);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(100, 23);
            this.txtDersKredi.TabIndex = 5;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(23, 154);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 6;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Location = new System.Drawing.Point(104, 154);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnDersGuncelle.TabIndex = 7;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(185, 154);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 23);
            this.btnDersSil.TabIndex = 8;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // dataGridDers
            // 
            this.dataGridDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDers.Location = new System.Drawing.Point(282, 32);
            this.dataGridDers.Name = "dataGridDers";
            this.dataGridDers.RowTemplate.Height = 25;
            this.dataGridDers.Size = new System.Drawing.Size(462, 145);
            this.dataGridDers.TabIndex = 9;
            this.dataGridDers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDers_CellClick);
            // 
            // DersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDers);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.txtDersKod);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DersEkle";
            this.Text = "DersEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDersAd;
        private TextBox txtDersKod;
        private TextBox txtDersKredi;
        private Button btnDersEkle;
        private Button btnDersGuncelle;
        private Button btnDersSil;
        private DataGridView dataGridDers;
    }
}