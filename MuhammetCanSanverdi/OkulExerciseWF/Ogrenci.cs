using OkulExerciseWF.Entity;
using SchoolExercise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteUygulama
{
    public partial class OgrenciForm : Form
    {
        SchoolDbContext _context;
        Diploma _yeniDiploma;
        public OgrenciForm()
        {
            InitializeComponent();
            _context = new SchoolDbContext();
            cbxDanisman.DataSource = _context.Danismanlar.ToList();
            OgrencileriGetir();
        }

        private void OgrencileriGetir()
        {
            dataGridView1.DataSource = _context.Ogrenciler.ToList();
        }

        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var ogrenci = (Ogrenci)dataGridView1.SelectedRows[0].DataBoundItem;
                txtbxAd.Text = ogrenci.Ad;
                txtbxSoyad.Text = ogrenci.Soyad;
                txtbxNumara.Text = ogrenci.Numara;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_yeniDiploma is null || _yeniDiploma.Id == 0)
            {
                MessageBox.Show("Yeniden diploma oluşturunuz.");
                btnNewDiploma.Enabled = true;
                btnNewDiploma.Text = "Yeni Diploma";
                return;
            }

            var yeniOgrenci = new Ogrenci();
            yeniOgrenci.Ad = txtbxAd.Text;
            yeniOgrenci.Soyad = txtbxSoyad.Text;
            yeniOgrenci.Numara = txtbxNumara.Text;
            yeniOgrenci.DiplomaId = _yeniDiploma.Id;
            yeniOgrenci.DanismanId = (cbxDanisman.SelectedItem as Danisman).Id;

            _context.Ogrenciler.Add(yeniOgrenci);
            _context.SaveChanges();
            OgrencileriGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekOgrenci = (Ogrenci)dataGridView1.SelectedRows[0].DataBoundItem;
            guncellenecekOgrenci.Ad = txtbxAd.Text;
            guncellenecekOgrenci.Soyad = txtbxSoyad.Text;
            guncellenecekOgrenci.Numara = txtbxNumara.Text;
            _context.Ogrenciler.Update(guncellenecekOgrenci);
            _context.SaveChanges();

            OgrencileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekOgrenci = (Ogrenci)dataGridView1.SelectedRows[0].DataBoundItem;
            _context.Ogrenciler.Remove(silinecekOgrenci);
            _context.SaveChanges();

            OgrencileriGetir();
        }

        private void btnNewDiploma_Click(object sender, EventArgs e)
        {
            _yeniDiploma = _context.Diplomalar.FirstOrDefault(d => d.Tarih == new DateTime(1, 1, 1) && d.No == 0);
            if (_yeniDiploma == null)
            {
                var yeniDiploma = new Diploma() { Tarih = DateTime.UtcNow };
                _context.Diplomalar.Add(yeniDiploma);
                _context.SaveChanges();
                _yeniDiploma = yeniDiploma;
            }
            btnNewDiploma.Enabled = false;
            btnNewDiploma.Text = "Oluşturuldu";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {

        }
    }
}
