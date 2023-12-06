namespace OgrenciSistemi
{
    public partial class OgrenciEkrani : Form
    {
        List<Ogrenci> ogrenciler;
        
        public OgrenciEkrani(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            this.ogrenciler = ogrenciler;
        }

        private void OgrenciEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ogrenciler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Numara = Convert.ToInt32(txtNumara.Text);
            ogrenciler.Add(ogrenci);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciler;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var o = (Ogrenci)dataGridView1.SelectedRows[0].DataBoundItem;
            o.Ad = txtAd.Text;
            o.Soyad = txtSoyad.Text;
            o.Numara = Convert.ToInt32(txtNumara.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciler;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var o = (Ogrenci)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtAd.Text = o.Ad;
            txtSoyad.Text = o.Soyad;
            txtNumara.Text = o.Numara.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var o = (Ogrenci)dataGridView1.SelectedRows[0].DataBoundItem;
            ogrenciler.Remove(o);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciler;
        }
    }
}