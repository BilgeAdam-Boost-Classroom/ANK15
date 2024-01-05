namespace RandomButonOyunu
{
    public partial class Form1 : Form
    {
        List<int> Sayilar = new List<int>();
        Random rnd = new Random();
  
        public Form1()
        {
            InitializeComponent();
            foreach (var control in butonContainer.Controls)
            {
                ((Button)(control)).Click += Islem;
                ((Button)(control)).Text += Islem;
            }
        }

        private void Islem(object sender, EventArgs args)
        {

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Oyun oyun = new Oyun();
            SayilariAta();
        }

        private void SayilariAta()
        {
            Sayilar.Clear();
           
            foreach (var item in butonContainer.Controls)
            {
                int rastgeleSayi;
                rastgeleSayi = rnd.Next(-4, 5);

                while (Sayilar.Contains(rastgeleSayi))
                {
                    rastgeleSayi = rnd.Next(-4, 5);
                }
                Sayilar.Add(rastgeleSayi);

                //((Button)(item)).Text
            }

        }
    }
}