namespace Transcript
{
    partial class OgrenciTranscript
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
            this.cbxOgrenci = new System.Windows.Forms.ComboBox();
            this.cbxDonem = new System.Windows.Forms.ComboBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dataGridTranscript = new System.Windows.Forms.DataGridView();
            this.lblDonemKredisi = new System.Windows.Forms.Label();
            this.lblDonemOrtalaması = new System.Windows.Forms.Label();
            this.lblToplamKredi = new System.Windows.Forms.Label();
            this.lblGenelOrtalaması = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTranscript)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dönem:";
            // 
            // cbxOgrenci
            // 
            this.cbxOgrenci.FormattingEnabled = true;
            this.cbxOgrenci.Location = new System.Drawing.Point(113, 29);
            this.cbxOgrenci.Name = "cbxOgrenci";
            this.cbxOgrenci.Size = new System.Drawing.Size(121, 23);
            this.cbxOgrenci.TabIndex = 2;
            // 
            // cbxDonem
            // 
            this.cbxDonem.FormattingEnabled = true;
            this.cbxDonem.Location = new System.Drawing.Point(349, 29);
            this.cbxDonem.Name = "cbxDonem";
            this.cbxDonem.Size = new System.Drawing.Size(121, 23);
            this.cbxDonem.TabIndex = 2;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(537, 19);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(186, 41);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // dataGridTranscript
            // 
            this.dataGridTranscript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTranscript.Location = new System.Drawing.Point(113, 78);
            this.dataGridTranscript.Name = "dataGridTranscript";
            this.dataGridTranscript.RowTemplate.Height = 25;
            this.dataGridTranscript.Size = new System.Drawing.Size(610, 271);
            this.dataGridTranscript.TabIndex = 4;
            // 
            // lblDonemKredisi
            // 
            this.lblDonemKredisi.AutoSize = true;
            this.lblDonemKredisi.Location = new System.Drawing.Point(196, 369);
            this.lblDonemKredisi.Name = "lblDonemKredisi";
            this.lblDonemKredisi.Size = new System.Drawing.Size(87, 15);
            this.lblDonemKredisi.TabIndex = 5;
            this.lblDonemKredisi.Text = "Dönem Kredisi:";
            // 
            // lblDonemOrtalaması
            // 
            this.lblDonemOrtalaması.AutoSize = true;
            this.lblDonemOrtalaması.Location = new System.Drawing.Point(404, 369);
            this.lblDonemOrtalaması.Name = "lblDonemOrtalaması";
            this.lblDonemOrtalaması.Size = new System.Drawing.Size(109, 15);
            this.lblDonemOrtalaması.TabIndex = 6;
            this.lblDonemOrtalaması.Text = "Dönem Ortalaması:";
            // 
            // lblToplamKredi
            // 
            this.lblToplamKredi.AutoSize = true;
            this.lblToplamKredi.Location = new System.Drawing.Point(196, 405);
            this.lblToplamKredi.Name = "lblToplamKredi";
            this.lblToplamKredi.Size = new System.Drawing.Size(79, 15);
            this.lblToplamKredi.TabIndex = 7;
            this.lblToplamKredi.Text = "Toplam Kredi:";
            // 
            // lblGenelOrtalaması
            // 
            this.lblGenelOrtalaması.AutoSize = true;
            this.lblGenelOrtalaması.Location = new System.Drawing.Point(404, 405);
            this.lblGenelOrtalaması.Name = "lblGenelOrtalaması";
            this.lblGenelOrtalaması.Size = new System.Drawing.Size(100, 15);
            this.lblGenelOrtalaması.TabIndex = 8;
            this.lblGenelOrtalaması.Text = "Genel Ortalaması:";
            // 
            // OgrenciTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGenelOrtalaması);
            this.Controls.Add(this.lblToplamKredi);
            this.Controls.Add(this.lblDonemOrtalaması);
            this.Controls.Add(this.lblDonemKredisi);
            this.Controls.Add(this.dataGridTranscript);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.cbxDonem);
            this.Controls.Add(this.cbxOgrenci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciTranscript";
            this.Text = "OgrenciTranscript";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTranscript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxOgrenci;
        private ComboBox cbxDonem;
        private Button btnGoster;
        private DataGridView dataGridTranscript;
        private Label lblDonemKredisi;
        private Label lblDonemOrtalaması;
        private Label lblToplamKredi;
        private Label lblGenelOrtalaması;
    }
}