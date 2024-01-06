
using System.Windows.Forms;

namespace UniversiteUygulama
{
    partial class DanismanForm
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
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtbxSoyad = new TextBox();
            txtbxAd = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad : ";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(17, 240);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 60);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(150, 240);
            btnGuncelle.Margin = new Padding(4, 5, 4, 5);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 60);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(283, 240);
            btnSil.Margin = new Padding(4, 5, 4, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 60);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtbxSoyad
            // 
            txtbxSoyad.Location = new Point(150, 143);
            txtbxSoyad.Margin = new Padding(4, 5, 4, 5);
            txtbxSoyad.Name = "txtbxSoyad";
            txtbxSoyad.Size = new Size(221, 31);
            txtbxSoyad.TabIndex = 6;
            // 
            // txtbxAd
            // 
            txtbxAd.Location = new Point(150, 85);
            txtbxAd.Margin = new Padding(4, 5, 4, 5);
            txtbxAd.Name = "txtbxAd";
            txtbxAd.Size = new Size(221, 31);
            txtbxAd.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(509, 50);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(571, 495);
            dataGridView1.TabIndex = 8;
            dataGridView1.RowStateChanged += DataGridView1_RowStateChanged;
            // 
            // DanismanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dataGridView1);
            Controls.Add(txtbxAd);
            Controls.Add(txtbxSoyad);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DanismanForm";
            Text = "Danisman";
            Load += DanismanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtbxSoyad;
        private TextBox txtbxAd;
        private DataGridView dataGridView1;
    }
}
