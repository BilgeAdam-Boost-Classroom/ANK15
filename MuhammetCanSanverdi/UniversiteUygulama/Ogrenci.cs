using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteUygulama.Models;

namespace UniversiteUygulama
{
    public partial class OgrenciForm : Form
    {
        UniversiteDbContext _context;
        Diplomalar _yeniDiploma;
        public OgrenciForm()
        {
            InitializeComponent();
            _context = new UniversiteDbContext();
            cbxDanisman.DataSource = _context.Danismanlars.ToList();
            dataGridView1.DataSource = _context.Ogrencilers.ToList();
        }

        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                var ogrenci = (Ogrenciler)dataGridView1.SelectedRows[0].DataBoundItem;
                txtbxAd.Text = ogrenci.Ad;
                txtbxSoyad.Text = ogrenci.Soyad;
                txtbxNumara.Text = ogrenci.Numara;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_yeniDiploma.Id != 0)
            {
                MessageBox.Show("Yeniden diploma oluşturunuz.");
                return;
            }

            var yeniOgrenci = new Ogrenciler();
            yeniOgrenci.Ad = txtbxAd.Text;
            yeniOgrenci.Soyad = txtbxSoyad.Text;
            yeniOgrenci.Numara = txtbxNumara.Text;
            yeniOgrenci.DiplomaId = _yeniDiploma.Id;

            _context.Ogrencilers.Add(yeniOgrenci);
            _context.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekOgrenci =(Ogrenciler)dataGridView1.SelectedRows[0].DataBoundItem;
            guncellenecekOgrenci.Ad = txtbxAd.Text;
            guncellenecekOgrenci.Soyad = txtbxSoyad.Text;
            guncellenecekOgrenci.Numara = txtbxNumara.Text;
            _context.Ogrencilers.Update(guncellenecekOgrenci);
            _context.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekOgrenci = (Ogrenciler)dataGridView1.SelectedRows[0].DataBoundItem;
            _context.Ogrencilers.Remove(silinecekOgrenci);
            _context.SaveChanges();
        }

        private void btnNewDiploma_Click(object sender, EventArgs e)
        {
            _yeniDiploma = _context.Diplomalars.FirstOrDefault(d => d.Tarih == new DateTime(1, 1, 1) && d.No == 0);
            if (_yeniDiploma == null)
            {
                _context.Diplomalars.Add(new());
                _context.SaveChanges();
                _yeniDiploma = _context.Diplomalars.FirstOrDefault(d => d.Tarih == new DateTime(1, 1, 1) && d.No == 0);
            }
            btnNewDiploma.Enabled = false;
            btnNewDiploma.Text = "Oluşturuldu";


        }
    }
}
