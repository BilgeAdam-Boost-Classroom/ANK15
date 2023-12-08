namespace Transcript
{
    public partial class OgrenciEkleSil : Form
    {
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        Ogrenci secilenOgrenci;
        public OgrenciEkleSil()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtOgrenciAd.Text;
            ogrenci.Soyad = txtOgrenciSoyad.Text;
            ogrenci.No = Convert.ToInt32(txtOgrenciNo.Text);
            ogrenciler.Add(ogrenci);
            dataGridOgrenci.DataSource = null;
            dataGridOgrenci.DataSource = ogrenciler;
        }


        private void dataGridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = (Ogrenci)dataGridOgrenci.Rows[e.RowIndex].DataBoundItem;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if(secilenOgrenci != null)
            {
                ogrenciler.Remove(secilenOgrenci);
                dataGridOgrenci.DataSource = null;
                dataGridOgrenci.DataSource = ogrenciler;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(secilenOgrenci != null)
            {
                secilenOgrenci.Ad = txtOgrenciAd.Text;
                secilenOgrenci.Soyad = txtOgrenciSoyad.Text;
                secilenOgrenci.No = Convert.ToInt32(txtOgrenciNo.Text);
                dataGridOgrenci.DataSource = null;
                dataGridOgrenci.DataSource = ogrenciler;
            }
        }
    }
}