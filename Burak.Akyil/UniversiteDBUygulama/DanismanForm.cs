using UniversiteDBUygulama.Models;

namespace UniversiteDBUygulama
{

    public partial class DanismanForm : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Danismanlar secilenDanisman;
        public DanismanForm()
        {
            InitializeComponent();
            Goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            string ad, soyad;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            Danismanlar danisman = new Danismanlar();
            danisman.Ad = ad;
            danisman.Soyad = soyad;
            _db.Danismanlars.Add(danisman);
            _db.SaveChanges();
            Goster();
            MessageBox.Show("Veritabanýna baþarýyla eklenmiþtir.");
        }
        public void Goster()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _db.Danismanlars.ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDanisman = (Danismanlar)dataGridView1.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenDanisman.Ad;
            txtSoyad.Text = secilenDanisman.Soyad;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenDanisman != null)
            {
                secilenDanisman.Ad = txtAd.Text;
                secilenDanisman.Soyad = txtSoyad.Text;
                _db.SaveChanges();
                MessageBox.Show("Baþarýyla güncellenmiþtir.");
                secilenDanisman = null;
                Goster();
            }
            else
            {
                MessageBox.Show("Lütfen danýþman seçiniz.");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenDanisman != null)
            {
                _db.Danismanlars.Remove(secilenDanisman);
                _db.SaveChanges();
                MessageBox.Show("Baþarýyla güncellenmiþtir.");
                secilenDanisman = null;
                Goster();
            }
            else
            {
                MessageBox.Show("Lütfen danýþman seçiniz.");
            }
        }
    }
}