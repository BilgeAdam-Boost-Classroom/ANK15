namespace Sınıf
{
    public partial class Form1 : Form
    {
        List<Calisan> Calisanlar = new List<Calisan>();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan yeniCalisan = new Calisan();
            yeniCalisan.Ad = txtAd.Text;
            yeniCalisan.Soyad = txtSoyad.Text;
            yeniCalisan.Yas = Convert.ToInt32(txtYas.Text);
            yeniCalisan.TC = Convert.ToInt64(txtTC.Text);
            if(txtAd.Text.Trim()=="" || txtSoyad.Text.Trim() == "" || txtYas.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
                return;
            }
            if(!long.TryParse(txtTC.Text, out long TC))
            {
                MessageBox.Show("Lütfen rakam giriniz.");
                return;
            }
            if (txtTC.Text.Length != 11)
            {
                MessageBox.Show("TC 11 haneli olmalıdır.");
                return;
            }
            foreach (var item in Calisanlar)
            {
                if(item.TC == Convert.ToInt64(txtTC.Text))
                {
                    MessageBox.Show("Girilen TC başka bir çalışanda mevcut.");
                    return;
                }

            }
            Calisanlar.Add(yeniCalisan);
            ltbCalisan.Items.Add(yeniCalisan);
            MessageBox.Show("Çalışan eklenmiştir.");
            
        }

        private void btnGosterilen_Click(object sender, EventArgs e)
        {
            if(Calisanlar.Count == 0)
            {
                MessageBox.Show("Lütfen en az 1 çalışan ekleyiniz.");
                return;
            }
            lblGosterilen.Text = Calisanlar[0].Ad + " " + Calisanlar[0].Soyad + " " + Calisanlar[0].Yas + " " + Calisanlar[0].TC;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (i != Calisanlar.Count-1)
            {
            i++;
            lblGosterilen.Text = Calisanlar[i].Ad + " " + Calisanlar[i].Soyad + " " + Calisanlar[i].Yas + " " + Calisanlar[i].TC;

            }
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {
            i--;
            lblGosterilen.Text = Calisanlar[i].Ad + " " + Calisanlar[i].Soyad + " " + Calisanlar[i].Yas + " " + Calisanlar[i].TC;
            }

        }

        
    }

}