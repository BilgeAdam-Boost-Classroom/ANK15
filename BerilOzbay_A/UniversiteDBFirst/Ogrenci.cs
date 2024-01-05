using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteDBFirst.Models;

namespace UniversiteDBFirst
{
    public partial class Ogrenci : Form
    {
        Ogrenciler secilenOgrenci = new Ogrenciler();
        public Ogrenci()
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            InitializeComponent();
            dataGridView1.DataSource = _db.Ogrenciler.ToList();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {

            UniversiteDbContext _db = new UniversiteDbContext();
            Ogrenciler yeniOgrenci = new Ogrenciler();

            yeniOgrenci.Ad = txtAdi.Text;
            yeniOgrenci.Soyad = txtSoyadi.Text;
            yeniOgrenci.Numara = txtNumara.Text;

            _db.Ogrenciler.Add(yeniOgrenci);
            _db.SaveChanges();

            dataGridView1.DataSource = _db.Ogrenciler.ToList();
            txtAdi.Clear();
            txtSoyadi.Clear();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = (Ogrenciler)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            txtAdi.Text = secilenOgrenci.Ad;
            txtSoyadi.Text = secilenOgrenci.Soyad;
            txtNumara.Text = secilenOgrenci.Numara;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            Ogrenciler guncellenecekOgrenci = _db.Ogrenciler.FirstOrDefault(d => d.Id == secilenOgrenci.Id);
            guncellenecekOgrenci.Ad = txtAdi.Text;
            guncellenecekOgrenci.Soyad = txtSoyadi.Text;
            guncellenecekOgrenci.Numara = txtNumara.Text;

            _db.SaveChanges();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtNumara.Clear();
            dataGridView1.DataSource = _db.Ogrenciler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            Ogrenciler silinecekOgrenci = _db.Ogrenciler.FirstOrDefault(d => d.Id == secilenOgrenci.Id);

            _db.Ogrenciler.Remove(silinecekOgrenci);
            _db.SaveChanges();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtNumara.Clear();
            dataGridView1.DataSource = _db.Ogrenciler.ToList();
        }
    }
}
