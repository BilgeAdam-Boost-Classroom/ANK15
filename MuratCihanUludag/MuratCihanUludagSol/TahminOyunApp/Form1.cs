using TahminOyunApp.Model;


namespace TahminOyunApp
{
    public partial class Form1 : Form
    {
        Oyun Oyun = new Oyun();
        private int progresBarValue = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            InitTimer();
            progressBar1.Value = 0;
            progressBar1.Maximum = 60;
            timer.Start();
        }

        private void InitTimer()
        {
            timer.Interval = 1000;
            timer.Tick += TimerTick;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            progresBarValue++;
            progressBar1.Value = progresBarValue;
            if (progressBar1.Maximum == progresBarValue)
            {
                timer.Stop();
                MessageBox.Show("Sureniz Dolmustur.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyun.TahminSayisi = Convert.ToInt32(textBox1.Text);
            if (Oyun.TahminSayisi != Oyun.TutulanSayi)
            {
                if (Oyun.TahminSayisi < Oyun.TutulanSayi)
                {
                    label3.Text = "Yukari";
                }
                else
                {
                    label3.Text = "Asagi";
                }
            }
            else
            {
                Oyun.Durum = true;
                Oyun.BilinmeAni = DateTime.Now;
                Oyun.BilinmeAni.ToString("ss:mm:hh");
                timer.Stop();   
                MessageBox.Show("Tebrikler Bildiniz");
            }
        }
    }
}