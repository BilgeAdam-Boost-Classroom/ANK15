namespace Example_User_Add
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
            btn_add = new Button();
            btn_update = new Button();
            btn_dalate = new Button();
            label1 = new Label();
            label2 = new Label();
            textName = new TextBox();
            textSurname = new TextBox();
            dataGridV1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridV1).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(42, 255);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 0;
            btn_add.Text = "Ekle";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(176, 255);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 1;
            btn_update.Text = "Guncelle";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_dalate
            // 
            btn_dalate.Location = new Point(325, 255);
            btn_dalate.Name = "btn_dalate";
            btn_dalate.Size = new Size(75, 23);
            btn_dalate.TabIndex = 2;
            btn_dalate.Text = "Sil";
            btn_dalate.UseVisualStyleBackColor = true;
            btn_dalate.Click += btn_dalate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 87);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 150);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Soyad:";
            // 
            // textName
            // 
            textName.Location = new Point(157, 87);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 5;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(157, 147);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(100, 23);
            textSurname.TabIndex = 6;
            // 
            // dataGridV1
            // 
            dataGridV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridV1.Location = new Point(414, 59);
            dataGridV1.Name = "dataGridV1";
            dataGridV1.Size = new Size(333, 171);
            dataGridV1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(414, 324);
            button1.Name = "button1";
            button1.Size = new Size(171, 47);
            button1.TabIndex = 8;
            button1.Text = "Ogrenci Islemleri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridV1);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_dalate);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridV1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_update;
        private Button btn_dalate;
        private Label label1;
        private Label label2;
        private TextBox textName;
        private TextBox textSurname;
        private DataGridView dataGridV1;
        private Button button1;
    }
}
