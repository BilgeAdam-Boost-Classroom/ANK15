namespace WinFormExercises
{
    partial class _14
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
            txtDers = new TextBox();
            btnAdd = new Button();
            cbxDers = new ComboBox();
            listbxDersler = new ListBox();
            btndontdo = new Button();
            SuspendLayout();
            // 
            // txtDers
            // 
            txtDers.Location = new Point(68, 17);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(522, 31);
            txtDers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(596, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxDers
            // 
            cbxDers.FormattingEnabled = true;
            cbxDers.Location = new Point(68, 54);
            cbxDers.Name = "cbxDers";
            cbxDers.Size = new Size(522, 33);
            cbxDers.TabIndex = 2;
            // 
            // listbxDersler
            // 
            listbxDersler.FormattingEnabled = true;
            listbxDersler.ItemHeight = 25;
            listbxDersler.Location = new Point(68, 93);
            listbxDersler.Name = "listbxDersler";
            listbxDersler.Size = new Size(522, 254);
            listbxDersler.TabIndex = 3;
            listbxDersler.SelectedIndexChanged += listbxDersler_SelectedIndexChanged;
            // 
            // btndontdo
            // 
            btndontdo.Location = new Point(68, 353);
            btndontdo.Name = "btndontdo";
            btndontdo.Size = new Size(522, 46);
            btndontdo.TabIndex = 4;
            btndontdo.Text = "HİÇ BİR ŞEY YAPMA!";
            btndontdo.UseVisualStyleBackColor = true;
            btndontdo.Click += button1_Click;
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndontdo);
            Controls.Add(listbxDersler);
            Controls.Add(cbxDers);
            Controls.Add(btnAdd);
            Controls.Add(txtDers);
            Name = "_14";
            Text = "_14";
            Load += _14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDers;
        private Button btnAdd;
        private ComboBox cbxDers;
        private ListBox listbxDersler;
        private Button btndontdo;
    }
}