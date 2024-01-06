using UniversiteUygulama.Models;

namespace UniversiteUygulama
{
    public partial class DanismanForm : Form
    {
        UniversiteDbContext _context;
        public DanismanForm()
        {
            InitializeComponent();
            _context = new UniversiteDbContext();
            dataGridView1.DataSource = _context.Danismanlars.ToList();
        }
        private void DanismanTablosunuYenile()
        {
            dataGridView1.DataSource = _context.Danismanlars.ToList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var danisman = new Danismanlar();
            danisman.Ad = txtbxAd.Text;
            danisman.Soyad = txtbxSoyad.Text;

            _context.Danismanlars.Add(danisman);
            _context.SaveChanges();
            DanismanTablosunuYenile();
        }
        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var danisman = (Danismanlar)dataGridView1.SelectedRows[0].DataBoundItem;
                txtbxAd.Text = danisman.Ad;
                txtbxSoyad.Text = danisman.Soyad;
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekDanisman = (Danismanlar)dataGridView1.SelectedRows[0].DataBoundItem;
            guncellenecekDanisman.Ad = txtbxAd.Text;
            guncellenecekDanisman.Soyad = txtbxSoyad.Text;
            _context.Danismanlars.Update(guncellenecekDanisman);
            _context.SaveChanges();
            DanismanTablosunuYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var guncellenecekDanisman = (Danismanlar)dataGridView1.SelectedRows[0].DataBoundItem;
            _context.Danismanlars.Remove(guncellenecekDanisman);
            _context.SaveChanges();
            DanismanTablosunuYenile();
        }

        private void DanismanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
