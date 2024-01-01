using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteEF1.Models;

namespace UniversiteEF1
{
    public partial class Ogrenci : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Ogrenciler secilenOgrenci; 
        public Ogrenci()
        {
            InitializeComponent();
            Goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad, soyad, numara;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            numara= txtNumara.Text;

            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Ad = ad;
            ogrenci.Soyad = soyad;
            ogrenci.Numara = numara;
            _db.Ogrencilers.Add(ogrenci);
            _db.SaveChanges();
            Goster();
            MessageBox.Show("veritabanına eklenmiştir");
        }
        private void Goster()
        {
            dGWOgrenciler.DataSource = null;
            dGWOgrenciler.DataSource = _db.Ogrencilers.ToList()
;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci != null)
            {
                secilenOgrenci.Ad = txtAd.Text;
                secilenOgrenci.Soyad = txtSoyad.Text;
                secilenOgrenci.Numara= txtNumara.Text;

                _db.SaveChanges();
                MessageBox.Show("başarıyla güncellenmiştir");
                secilenOgrenci = null;
                lblsecilenOgrenci.Text = "Seçilen Ogrenci:";
                Goster();

            }
            else
                MessageBox.Show("Ogrenci seç");
        }

        private void dGWOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = (Ogrenciler)dGWOgrenciler.SelectedRows[0].DataBoundItem; //satırdaki tıklanan
            txtAd.Text = secilenOgrenci.Ad;
            txtSoyad.Text = secilenOgrenci.Soyad;
            txtNumara.Text = secilenOgrenci.Numara;

            lblsecilenOgrenci.Text = "Seçilen Öğrenci:" + secilenOgrenci.Ad + " " + secilenOgrenci.Soyad +" " +secilenOgrenci.Numara;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci != null)
            {
                _db.Ogrencilers.Remove(secilenOgrenci);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenOgrenci = null;
                lblsecilenOgrenci.Text = "Seçilen Öğrenci:";
                Goster();

            }
            else
                MessageBox.Show("öğrenci seç");
        }
    }
}
