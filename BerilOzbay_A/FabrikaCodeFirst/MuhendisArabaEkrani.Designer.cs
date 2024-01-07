namespace FabrikaCodeFirst
{
    partial class MuhendisArabaEkrani
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
            cbxMuhendis = new ComboBox();
            cbxAraba = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgvMuhendisAraba = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMuhendisAraba).BeginInit();
            SuspendLayout();
            // 
            // cbxMuhendis
            // 
            cbxMuhendis.FormattingEnabled = true;
            cbxMuhendis.Location = new Point(687, 57);
            cbxMuhendis.Name = "cbxMuhendis";
            cbxMuhendis.Size = new Size(232, 28);
            cbxMuhendis.TabIndex = 9;
            // 
            // cbxAraba
            // 
            cbxAraba.FormattingEnabled = true;
            cbxAraba.Location = new Point(362, 57);
            cbxAraba.Name = "cbxAraba";
            cbxAraba.Size = new Size(188, 28);
            cbxAraba.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 60);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Muhendis:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 60);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Araba:";
            // 
            // dgvMuhendisAraba
            // 
            dgvMuhendisAraba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuhendisAraba.Location = new Point(134, 119);
            dgvMuhendisAraba.Name = "dgvMuhendisAraba";
            dgvMuhendisAraba.RowHeadersWidth = 51;
            dgvMuhendisAraba.RowTemplate.Height = 29;
            dgvMuhendisAraba.Size = new Size(1005, 491);
            dgvMuhendisAraba.TabIndex = 10;
            dgvMuhendisAraba.CellClick += dgvMuhendisAraba_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(304, 638);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(922, 638);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // MuhendisArabaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 693);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMuhendisAraba);
            Controls.Add(cbxMuhendis);
            Controls.Add(cbxAraba);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MuhendisArabaEkrani";
            Text = "MuhendisArabaEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvMuhendisAraba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxMuhendis;
        private ComboBox cbxAraba;
        private Label label2;
        private Label label1;
        private DataGridView dgvMuhendisAraba;
        private Button btnEkle;
        private Button btnSil;
    }
}