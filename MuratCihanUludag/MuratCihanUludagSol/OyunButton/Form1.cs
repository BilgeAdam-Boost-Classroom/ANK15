namespace OyunButton
{
    public partial class Form1 : Form
    {
        List<int> list;
        List<Button> buttons;
        Oyun oyun;
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>() {button1,button2,button3,button4,button5,button6,button7,button8,button9 };

            foreach (var item in buttons)
            {
                item.Click += BtnSelecet;
                item.Enabled = false;   
            }
        }

        private void BtnSelecet(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (oyun.Sayi1 == -5)
            {
                button.Text = button.Tag.ToString();
                oyun.Sayi1 = Convert.ToInt32(button.Text);
                button.Enabled = false;
                
            }
            else if(oyun.Sayi2 == -5)
            {
                button.Text = button.Tag.ToString();
                oyun.Sayi2 = Convert.ToInt32(button.Text);
            }
            if (oyun.Sayi1 != -5 && oyun.Sayi2 != -5)
            {
                GameReasult();   
            }
        }
        private void GameReasult () 
        {
            if (oyun.Toplam() == 0)
            {
                oyun.Durum = Durum.Kazandi;
            }
            else
            {
                oyun.Durum = Durum.Kaybetti;
            }
            MessageBox.Show(oyun.Durum.ToString());
            foreach (var item in buttons)
            {
                item.Enabled = false;
            }

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            oyun = new Oyun();
            list = new List<int>() { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            button1.Text = list[0].ToString();
            for (int i = 0; i < 9; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(list.Count);
                int randomNumber = list[randomIndex];
                list.Remove(randomIndex);
                Button button = buttons[i];
                button.Enabled = true;  
                button.Tag = randomNumber.ToString();
                button.Text = "X";
            }
        }
    }
}