namespace Calisanlar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textName = new TextBox();
            textSurname = new TextBox();
            textAge = new TextBox();
            textTc = new TextBox();
            button1 = new Button();
            Goruntule = new GroupBox();
            btnGeri = new Button();
            btnIler = new Button();
            btnGoster = new Button();
            fullLabel = new Label();
            allWorkers = new GroupBox();
            listBox1 = new ListBox();
            Goruntule.SuspendLayout();
            allWorkers.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 99);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 160);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "SoyAd:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 220);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Yas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 286);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 3;
            label4.Text = "Tc:";
            // 
            // textName
            // 
            textName.Location = new Point(176, 96);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 4;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(176, 152);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(100, 23);
            textSurname.TabIndex = 5;
            // 
            // textAge
            // 
            textAge.Location = new Point(176, 212);
            textAge.Name = "textAge";
            textAge.Size = new Size(100, 23);
            textAge.TabIndex = 6;
            // 
            // textTc
            // 
            textTc.Location = new Point(176, 278);
            textTc.Name = "textTc";
            textTc.Size = new Size(100, 23);
            textTc.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(162, 344);
            button1.Name = "button1";
            button1.Size = new Size(114, 38);
            button1.TabIndex = 8;
            button1.Text = "Calisan Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Goruntule
            // 
            Goruntule.Controls.Add(btnGeri);
            Goruntule.Controls.Add(btnIler);
            Goruntule.Controls.Add(btnGoster);
            Goruntule.Controls.Add(fullLabel);
            Goruntule.Location = new Point(386, 96);
            Goruntule.Name = "Goruntule";
            Goruntule.Size = new Size(324, 286);
            Goruntule.TabIndex = 9;
            Goruntule.TabStop = false;
            Goruntule.Text = "Goruntule";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(102, 238);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(32, 32);
            btnGeri.TabIndex = 13;
            btnGeri.Text = "<";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnIler
            // 
            btnIler.Location = new Point(183, 238);
            btnIler.Name = "btnIler";
            btnIler.Size = new Size(32, 32);
            btnIler.TabIndex = 12;
            btnIler.Text = ">";
            btnIler.UseVisualStyleBackColor = true;
            btnIler.Click += btnIler_Click;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(102, 171);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(113, 43);
            btnGoster.TabIndex = 11;
            btnGoster.Text = "Goster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // fullLabel
            // 
            fullLabel.BorderStyle = BorderStyle.FixedSingle;
            fullLabel.Location = new Point(52, 19);
            fullLabel.Name = "fullLabel";
            fullLabel.Size = new Size(216, 120);
            fullLabel.TabIndex = 10;
            fullLabel.Text = "label5";
            // 
            // allWorkers
            // 
            allWorkers.Controls.Add(listBox1);
            allWorkers.Location = new Point(745, 99);
            allWorkers.Name = "allWorkers";
            allWorkers.Size = new Size(328, 283);
            allWorkers.TabIndex = 10;
            allWorkers.TabStop = false;
            allWorkers.Text = "Tum Calisanlar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 244);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 577);
            Controls.Add(allWorkers);
            Controls.Add(Goruntule);
            Controls.Add(button1);
            Controls.Add(textTc);
            Controls.Add(textAge);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Goruntule.ResumeLayout(false);
            allWorkers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private TextBox textSurname;
        private TextBox textAge;
        private TextBox textTc;
        private Button button1;
        private GroupBox Goruntule;
        private Button btnGeri;
        private Button btnIler;
        private Button btnGoster;
        private Label fullLabel;
        private GroupBox allWorkers;
        private ListBox listBox1;
    }
}