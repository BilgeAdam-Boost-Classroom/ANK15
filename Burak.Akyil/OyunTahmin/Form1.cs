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
                MessageBox.Show("S�re bitti.");
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
                    MessageBox.Show("L�tfen [1, 100] arali�inda bir de�er giriniz.");
                    return;
                }


                if (Convert.ToInt32(txtSayi.Text) == oyun.TutulanSay�)
                {
                    oyun.Durum = true;
                    timer1.Stop();
                    KontrolleriDuzenle(false);
                    lblBilgi.Text = "";
                    MessageBox.Show($"{oyun.TahminSayisi}. denemede KAZANDINIZ!!!");
                    oyun.BilinmeAni = DateTime.Now;
                }
                else if (Convert.ToInt32(txtSayi.Text) > oyun.TutulanSay�)
                {
                    lblBilgi.Text = "A�A�I";
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


            if(Convert.ToInt32(txtSayi.Text) == oyun.TutulanSay�)
            {
                oyun.Durum = true;
                timer1.Stop();
                KontrolleriDuzenle(false);
                lblBilgi.Text = "";
                MessageBox.Show($"{oyun.TahminSayisi}. denemede KAZANDINIZ!!!");
                oyun.BilinmeAni = DateTime.Now;
            }
            else if(Convert.ToInt32(txtSayi.Text) > oyun.TutulanSay�)
            {
                lblBilgi.Text = "A�A�I";
            }
            else
            {
                lblBilgi.Text = "YUKARI";
            }
            
        }
    }
}