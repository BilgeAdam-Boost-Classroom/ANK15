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
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.Yas = Convert.ToInt32(txtYas.Text);
            calisan.TC = Convert.ToInt64(txtTC.Text);
            calisanlar.Add(calisan);

            listBox1.DataSource = calisanlar;
            MessageBox.Show($"{calisan.TC} listeye eklendi");
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTC.Clear();


        }
    }
}