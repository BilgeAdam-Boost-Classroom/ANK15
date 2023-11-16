namespace calisan_bilgileri
{
    public partial class Form1 : Form
    {
        List<Calisan> calisanlar = new List<Calisan>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            //if (calisanlar.Count == 0)
            //{
            //    MessageBox.Show("l�tfen 1 ki�i bekleyiniz!");
            //    return;
            //}
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.Yas = Convert.ToInt32(txtYas.Text);
            calisan.TC = Convert.ToInt64(txtTC.Text);
            if (txtTC.TextLength != 11)
            {
                MessageBox.Show("Hatal� TC Kimlik Numaras�! L�tfen 11 haneli do�ru bir TC Kimlik Numaras� giriniz.");
                return;
            }
            calisanlar.Add(calisan);
            listBox1.Items.Add(calisan);
            MessageBox.Show($"{calisan} listeye eklendi");
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTC.Clear();
        }
        int siraNo = 0;
        private void btn�nceki_Click(object sender, EventArgs e)
        {
            if (siraNo != calisanlar.Count-1)
            {
                siraNo--;
                lblG�r�nen.Text = calisanlar[siraNo].Ad + calisanlar[siraNo].Soyad + calisanlar[siraNo].Yas + calisanlar[siraNo].TC;
            }
        }
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (siraNo >= calisanlar.Count + 1)
            {
                siraNo++;
                lblG�r�nen.Text = calisanlar[siraNo].Ad + calisanlar[siraNo].Soyad + calisanlar[siraNo].Yas + calisanlar[siraNo].TC;
            }
        }
        private void lblG�r�nen_Click(object sender, EventArgs e)
        {
            lblG�r�nen.Text = calisanlar[0].Ad + calisanlar[0].Soyad + calisanlar[0].Yas + calisanlar[0].TC;
        }

        private void btnG�ster_Click(object sender, EventArgs e)
        {
            lblG�r�nen.Text = calisanlar[0].Ad + "" + calisanlar[0].Soyad + "" + calisanlar[0].Yas + "" + calisanlar[0].TC + "";
        }
    }
}