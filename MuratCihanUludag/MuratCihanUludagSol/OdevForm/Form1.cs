namespace OdevForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Form messageBox = new Form();
            if (!(userName.Text == "admin" && password.Text == "1234"))
            {
                MessageBoxCustom(messageBox);
            }
            else
            {
                Label labelHome = new Label();

                messageBox.Width = 400;
                messageBox.Height = 200;
                messageBox.Text = "AnaSayfa";

                messageBox.Location = new Point(200, 100);
                messageBox.AutoSize = true;
                labelHome.Location = new Point(0, 0);
                labelHome.Text = "Admin Hosgeldin";

                messageBox.Controls.Add(labelHome);

            }
                messageBox.ShowDialog();
  
        
        }
        public void MessageBoxCustom(Form messageBox)
        {
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            Label messageLabel = new Label();
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = SystemIcons.Warning.ToBitmap();

            messageBox.Width = 300;
            messageBox.Height = 200;

            buttonOk.Location = new Point(120, 120);
            buttonCancel.Location = new Point(200, 120);
            messageLabel.Location = new Point(80, 50);
            pictureBox.Location = new Point(40, 40);

            messageLabel.AutoSize = true;

            messageBox.Text = "Uyari Mesaji!";
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            messageLabel.Text = "Kullanici adi veya sifre hatali!";

            messageBox.Controls.Add(buttonOk);
            messageBox.Controls.Add(buttonCancel);
            messageBox.Controls.Add(messageLabel);
            messageBox.Controls.Add(pictureBox);
            ButtonOk(buttonOk, messageBox);

        }
        public void ButtonOk(Button button,Form form)
        {
            button.Click += (sender, e) =>
            {
                form.Close();
            };
        }
    }
}