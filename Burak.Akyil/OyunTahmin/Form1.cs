namespace OyunTahmin
{
    public partial class Form1 : Form
    {
        Oyun oyun = new Oyun();
        public Form1()
        {
            InitializeComponent();
        }
        private void KontrolleriDuzenle(bool deger)
        {
            txtSayi.Enabled = deger;
            btnTahmin.Enabled = deger;
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            KontrolleriDuzenle(true);
            timer1.Start();
            progressBar1.Value = 0;
        }
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 60)
            {
                timer1.Stop();
                KontrolleriDuzenle(false);
                MessageBox.Show("Süre bitti.");
                return;
            }
            progressBar1.Value++;

        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            oyun.TahminSayisi++;
            try
            {
                if(Convert.ToInt32(txtSayi.Text) < 0 || Convert.ToInt32(txtSayi.Text) > 100)
                {
                    MessageBox.Show("Lütfen [1, 100] araliðinda bir deðer giriniz.");
                    return;
                }


                if (Convert.ToInt32(txtSayi.Text) == oyun.TutulanSayý)
                {
                    oyun.Durum = true;
                    timer1.Stop();
                    KontrolleriDuzenle(false);
                    lblBilgi.Text = "";
                    MessageBox.Show($"{oyun.TahminSayisi}. denemede KAZANDINIZ!!!");
                    oyun.BilinmeAni = DateTime.Now;
                }
                else if (Convert.ToInt32(txtSayi.Text) > oyun.TutulanSayý)
                {
                    lblBilgi.Text = "AÞAÐI";
                }
                else
                {
                    lblBilgi.Text = "YUKARI";
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata: " + hata.Message);
            }


            if(Convert.ToInt32(txtSayi.Text) == oyun.TutulanSayý)
            {
                oyun.Durum = true;
                timer1.Stop();
                KontrolleriDuzenle(false);
                lblBilgi.Text = "";
                MessageBox.Show($"{oyun.TahminSayisi}. denemede KAZANDINIZ!!!");
                oyun.BilinmeAni = DateTime.Now;
            }
            else if(Convert.ToInt32(txtSayi.Text) > oyun.TutulanSayý)
            {
                lblBilgi.Text = "AÞAÐI";
            }
            else
            {
                lblBilgi.Text = "YUKARI";
            }
            
        }
    }
}