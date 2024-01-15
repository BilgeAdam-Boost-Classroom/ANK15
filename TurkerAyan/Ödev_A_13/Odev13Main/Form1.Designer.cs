namespace Odev13Main
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
            btnLPEkle = new Button();
            txtPlate = new TextBox();
            label1 = new Label();
            dgvLP = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnCarEkle = new Button();
            button2 = new Button();
            button3 = new Button();
            txtCarName = new TextBox();
            label2 = new Label();
            dgvCars = new DataGridView();
            cbxLP = new ComboBox();
            cbxPersons = new ComboBox();
            textBox1 = new TextBox();
            lbxEngineers = new ListBox();
            btnPersonEkle = new Button();
            button5 = new Button();
            button6 = new Button();
            txtPersonName = new TextBox();
            label3 = new Label();
            dgvPersons = new DataGridView();
            lbxCars = new ListBox();
            txtLastName = new TextBox();
            btnEngineersEkle = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            dgvEngineers = new DataGridView();
            lbxEngineersCars = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvLP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEngineers).BeginInit();
            SuspendLayout();
            // 
            // btnLPEkle
            // 
            btnLPEkle.Location = new Point(12, 184);
            btnLPEkle.Name = "btnLPEkle";
            btnLPEkle.Size = new Size(45, 23);
            btnLPEkle.TabIndex = 0;
            btnLPEkle.Text = "Ekle";
            btnLPEkle.UseVisualStyleBackColor = false;
            btnLPEkle.Click += btnLPEkle_Click;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(12, 26);
            txtPlate.Name = "txtPlate";
            txtPlate.PlaceholderText = "Plate Number";
            txtPlate.Size = new Size(100, 23);
            txtPlate.TabIndex = 1;
            txtPlate.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "LicencePlate";
            // 
            // dgvLP
            // 
            dgvLP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLP.Location = new Point(12, 57);
            dgvLP.Name = "dgvLP";
            dgvLP.Size = new Size(120, 121);
            dgvLP.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(63, 184);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(45, 23);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(40, 213);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(45, 23);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnCarEkle
            // 
            btnCarEkle.Location = new Point(150, 393);
            btnCarEkle.Name = "btnCarEkle";
            btnCarEkle.Size = new Size(45, 23);
            btnCarEkle.TabIndex = 0;
            btnCarEkle.Text = "Ekle";
            btnCarEkle.UseVisualStyleBackColor = false;
            btnCarEkle.Click += btnCarEkle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(201, 393);
            button2.Name = "button2";
            button2.Size = new Size(45, 23);
            button2.TabIndex = 0;
            button2.Text = "Guncelle";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(178, 422);
            button3.Name = "button3";
            button3.Size = new Size(45, 23);
            button3.TabIndex = 0;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(150, 26);
            txtCarName.Name = "txtCarName";
            txtCarName.PlaceholderText = "BrandName";
            txtCarName.Size = new Size(120, 23);
            txtCarName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 8);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Car";
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(150, 240);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(120, 147);
            dgvCars.TabIndex = 3;
            // 
            // cbxLP
            // 
            cbxLP.FormattingEnabled = true;
            cbxLP.Location = new Point(150, 57);
            cbxLP.Name = "cbxLP";
            cbxLP.Size = new Size(121, 23);
            cbxLP.TabIndex = 4;
            cbxLP.Text = "Licence Plate";
            // 
            // cbxPersons
            // 
            cbxPersons.FormattingEnabled = true;
            cbxPersons.Location = new Point(150, 86);
            cbxPersons.Name = "cbxPersons";
            cbxPersons.Size = new Size(121, 23);
            cbxPersons.TabIndex = 4;
            cbxPersons.Text = "Person";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // lbxEngineers
            // 
            lbxEngineers.FormattingEnabled = true;
            lbxEngineers.ItemHeight = 15;
            lbxEngineers.Location = new Point(151, 113);
            lbxEngineers.Name = "lbxEngineers";
            lbxEngineers.SelectionMode = SelectionMode.MultiSimple;
            lbxEngineers.Size = new Size(120, 109);
            lbxEngineers.TabIndex = 7;
            // 
            // btnPersonEkle
            // 
            btnPersonEkle.Location = new Point(276, 393);
            btnPersonEkle.Name = "btnPersonEkle";
            btnPersonEkle.Size = new Size(45, 23);
            btnPersonEkle.TabIndex = 0;
            btnPersonEkle.Text = "Ekle";
            btnPersonEkle.UseVisualStyleBackColor = false;
            btnPersonEkle.Click += btnPersonEkle_Click;
            // 
            // button5
            // 
            button5.Location = new Point(327, 393);
            button5.Name = "button5";
            button5.Size = new Size(45, 23);
            button5.TabIndex = 0;
            button5.Text = "Guncelle";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Location = new Point(304, 422);
            button6.Name = "button6";
            button6.Size = new Size(45, 23);
            button6.TabIndex = 0;
            button6.Text = "Sil";
            button6.UseVisualStyleBackColor = false;
            // 
            // txtPersonName
            // 
            txtPersonName.Location = new Point(276, 26);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.PlaceholderText = "FirstName";
            txtPersonName.Size = new Size(120, 23);
            txtPersonName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 8);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Person";
            // 
            // dgvPersons
            // 
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(276, 240);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.Size = new Size(120, 147);
            dgvPersons.TabIndex = 3;
            // 
            // lbxCars
            // 
            lbxCars.FormattingEnabled = true;
            lbxCars.ItemHeight = 15;
            lbxCars.Location = new Point(277, 113);
            lbxCars.Name = "lbxCars";
            lbxCars.SelectionMode = SelectionMode.MultiSimple;
            lbxCars.Size = new Size(120, 109);
            lbxCars.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(277, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName";
            txtLastName.Size = new Size(120, 23);
            txtLastName.TabIndex = 1;
            // 
            // btnEngineersEkle
            // 
            btnEngineersEkle.Location = new Point(402, 393);
            btnEngineersEkle.Name = "btnEngineersEkle";
            btnEngineersEkle.Size = new Size(45, 23);
            btnEngineersEkle.TabIndex = 0;
            btnEngineersEkle.Text = "Ekle";
            btnEngineersEkle.UseVisualStyleBackColor = false;
            btnEngineersEkle.Click += btnEngineersEkle_Click;
            // 
            // button8
            // 
            button8.Location = new Point(453, 393);
            button8.Name = "button8";
            button8.Size = new Size(45, 23);
            button8.TabIndex = 0;
            button8.Text = "Guncelle";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.Location = new Point(430, 422);
            button9.Name = "button9";
            button9.Size = new Size(45, 23);
            button9.TabIndex = 0;
            button9.Text = "Sil";
            button9.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(402, 26);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "FirstName";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 55);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "LastName";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 8);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 2;
            label4.Text = "Engineers";
            // 
            // dgvEngineers
            // 
            dgvEngineers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEngineers.Location = new Point(402, 240);
            dgvEngineers.Name = "dgvEngineers";
            dgvEngineers.Size = new Size(120, 147);
            dgvEngineers.TabIndex = 3;
            // 
            // lbxEngineersCars
            // 
            lbxEngineersCars.FormattingEnabled = true;
            lbxEngineersCars.ItemHeight = 15;
            lbxEngineersCars.Location = new Point(403, 113);
            lbxEngineersCars.Name = "lbxEngineersCars";
            lbxEngineersCars.SelectionMode = SelectionMode.MultiSimple;
            lbxEngineersCars.Size = new Size(120, 109);
            lbxEngineersCars.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbxEngineersCars);
            Controls.Add(lbxCars);
            Controls.Add(lbxEngineers);
            Controls.Add(textBox1);
            Controls.Add(cbxPersons);
            Controls.Add(dgvEngineers);
            Controls.Add(dgvPersons);
            Controls.Add(label4);
            Controls.Add(cbxLP);
            Controls.Add(label3);
            Controls.Add(dgvCars);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(txtLastName);
            Controls.Add(txtPersonName);
            Controls.Add(dgvLP);
            Controls.Add(button9);
            Controls.Add(txtCarName);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(txtPlate);
            Controls.Add(btnEngineersEkle);
            Controls.Add(button2);
            Controls.Add(btnPersonEkle);
            Controls.Add(btnSil);
            Controls.Add(btnCarEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnLPEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEngineers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLPEkle;
        private TextBox txtPlate;
        private Label label1;
        private DataGridView dgvLP;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnCarEkle;
        private Button button2;
        private Button button3;
        private TextBox txtCarName;
        private Label label2;
        private DataGridView dgvCars;
        private DataGridView dataGridView2;
        private ComboBox cbxLP;
        private ComboBox cbxPersons;
        private TextBox textBox1;
        private ListBox lbxEngineers;
        private ListBox listBox1;
        private Button btnPersonEkle;
        private Button button5;
        private Button button6;
        private TextBox txtPersonName;
        private Label label3;
        private DataGridView dgvPersons;
        private DataGridView dataGridView3;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ListBox lbxCars;
        private TextBox txtLastName;
        private Button btnEngineersEkle;
        private Button button8;
        private Button button9;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dgvEngineers;
        private ListBox lbxEngineersCars;
    }
}
