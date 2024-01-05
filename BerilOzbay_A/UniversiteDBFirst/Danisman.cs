using System.Data;
using UniversiteDBFirst.Models;

namespace UniversiteDBFirst
{
    public partial class Danisman : Form
    {
        Danismanlar secilenDanisman = new Danismanlar();

        public Danisman()
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            InitializeComponent();
            dataGridView1.DataSource = _db.Danismanlar.ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridden secili ders elde edilir.
            secilenDanisman = (Danismanlar)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            txtAdi.Text = secilenDanisman.Ad;
            txtSoyadi.Text = secilenDanisman.Soyad;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            UniversiteDbContext _db = new UniversiteDbContext();
            Danismanlar yeniDanisman = new Danismanlar();

            yeniDanisman.Ad = txtAdi.Text;
            yeniDanisman.Soyad = txtSoyadi.Text;

            _db.Danismanlar.Add(yeniDanisman);
            _db.SaveChanges();

            dataGridView1.DataSource = _db.Danismanlar.ToList();
            txtAdi.Clear();
            txtSoyadi.Clear();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            Danismanlar guncellenecekDanisman = _db.Danismanlar.FirstOrDefault(d => d.Id == secilenDanisman.Id);
            guncellenecekDanisman.Ad = txtAdi.Text;
            guncellenecekDanisman.Soyad = txtSoyadi.Text;

            _db.SaveChanges();
            txtAdi.Clear();
            txtSoyadi.Clear();
            dataGridView1.DataSource = _db.Danismanlar.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            Danismanlar silinecekDanisman = _db.Danismanlar.FirstOrDefault(d => d.Id == secilenDanisman.Id);

            _db.Danismanlar.Remove(silinecekDanisman);
            _db.SaveChanges();
            txtAdi.Clear();
            txtSoyadi.Clear();
            dataGridView1.DataSource = _db.Danismanlar.ToList();
        }

    }
}