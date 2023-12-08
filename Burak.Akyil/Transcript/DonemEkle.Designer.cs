namespace Transcript
{
    partial class DonemEkle
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
            this.txtDonemAd = new System.Windows.Forms.TextBox();
            this.txtDonemNo = new System.Windows.Forms.TextBox();
            this.btnDonemEkle = new System.Windows.Forms.Button();
            this.btnDonemGuncelle = new System.Windows.Forms.Button();
            this.btnDonemSil = new System.Windows.Forms.Button();
            this.dataGridDonem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "No:";
            // 
            // txtDonemAd
            // 
            this.txtDonemAd.Location = new System.Drawing.Point(90, 53);
            this.txtDonemAd.Name = "txtDonemAd";
            this.txtDonemAd.Size = new System.Drawing.Size(100, 23);
            this.txtDonemAd.TabIndex = 2;
            // 
            // txtDonemNo
            // 
            this.txtDonemNo.Location = new System.Drawing.Point(90, 82);
            this.txtDonemNo.Name = "txtDonemNo";
            this.txtDonemNo.Size = new System.Drawing.Size(100, 23);
            this.txtDonemNo.TabIndex = 2;
            // 
            // btnDonemEkle
            // 
            this.btnDonemEkle.Location = new System.Drawing.Point(12, 138);
            this.btnDonemEkle.Name = "btnDonemEkle";
            this.btnDonemEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDonemEkle.TabIndex = 3;
            this.btnDonemEkle.Text = "Ekle";
            this.btnDonemEkle.UseVisualStyleBackColor = true;
            this.btnDonemEkle.Click += new System.EventHandler(this.btnDonemEkle_Click);
            // 
            // btnDonemGuncelle
            // 
            this.btnDonemGuncelle.Location = new System.Drawing.Point(93, 138);
            this.btnDonemGuncelle.Name = "btnDonemGuncelle";
            this.btnDonemGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnDonemGuncelle.TabIndex = 4;
            this.btnDonemGuncelle.Text = "Güncelle";
            this.btnDonemGuncelle.UseVisualStyleBackColor = true;
            this.btnDonemGuncelle.Click += new System.EventHandler(this.btnDonemGuncelle_Click);
            // 
            // btnDonemSil
            // 
            this.btnDonemSil.Location = new System.Drawing.Point(174, 138);
            this.btnDonemSil.Name = "btnDonemSil";
            this.btnDonemSil.Size = new System.Drawing.Size(75, 23);
            this.btnDonemSil.TabIndex = 5;
            this.btnDonemSil.Text = "Sil";
            this.btnDonemSil.UseVisualStyleBackColor = true;
            this.btnDonemSil.Click += new System.EventHandler(this.btnDonemSil_Click);
            // 
            // dataGridDonem
            // 
            this.dataGridDonem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDonem.Location = new System.Drawing.Point(307, 53);
            this.dataGridDonem.Name = "dataGridDonem";
            this.dataGridDonem.RowTemplate.Height = 25;
            this.dataGridDonem.Size = new System.Drawing.Size(429, 134);
            this.dataGridDonem.TabIndex = 6;
            this.dataGridDonem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDonem_CellClick);
            // 
            // DonemEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDonem);
            this.Controls.Add(this.btnDonemSil);
            this.Controls.Add(this.btnDonemGuncelle);
            this.Controls.Add(this.btnDonemEkle);
            this.Controls.Add(this.txtDonemNo);
            this.Controls.Add(this.txtDonemAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DonemEkle";
            this.Text = "DonemEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDonemAd;
        private TextBox txtDonemNo;
        private Button btnDonemEkle;
        private Button btnDonemGuncelle;
        private Button btnDonemSil;
        private DataGridView dataGridDonem;
    }
}