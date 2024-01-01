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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversiteEF1
{
    public partial class OgrenciyeDers : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Ogrenciler secilenOgrenci;
        Dersler eklenecekDers;
        Dersler silinecekDers;
        List<OgrenciDersler> butunOgrenciDersleri;
        public OgrenciyeDers()
        {
            InitializeComponent();
            Goster();
        }

        private void Goster()
        {
            cmbOgrenciler.DataSource = _db.Ogrencilers.ToList();
            cmbDersler.DataSource = _db.Derslers.ToList();
            cmbOgrenciler.SelectedIndex = -1;
            cmbDersler.SelectedIndex = -1;
        }

        private void OgrenciDersleriGetir()
        {
            butunOgrenciDersleri = _db.OgrenciDerslers.ToList();
            secilenOgrenci = (Ogrenciler)cmbOgrenciler.SelectedItem;

            if (secilenOgrenci != null)
            {
                List<OgrenciDersler> secilenOgrencininDersleri = butunOgrenciDersleri.FindAll(d => d.Ogrenci.Id == secilenOgrenci.Id);
                dGWOgrenciyeDers.DataSource = null;
                dGWOgrenciyeDers.DataSource = secilenOgrencininDersleri.Select(x => x.Ders).ToList();
            }
        }

        private void dGWOgrenciyeDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            silinecekDers = (Dersler)dGWOgrenciyeDers.SelectedRows[0].DataBoundItem; //satırdaki tıklanan
        }

        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrenciDersleriGetir();
        }

        private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            eklenecekDers = (Dersler)cmbDersler.SelectedItem;
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci.OgrenciDerslers.Any(d => d.DersId == eklenecekDers.Id))
            {
                MessageBox.Show("Seçilen öğrenci, seçilen dersi halihazırda almaktadır.");
            }
            else
            {
                OgrenciDersler ogrenciDers = new OgrenciDersler();
                ogrenciDers.Ogrenci = secilenOgrenci;
                ogrenciDers.Ders = eklenecekDers;
                _db.OgrenciDerslers.Add(ogrenciDers);
                _db.SaveChanges();
                OgrenciDersleriGetir();
                MessageBox.Show("veritabanına eklenmiştir");
            }
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (silinecekDers != null)
            {
                OgrenciDersler silinecekOgrenciDers = butunOgrenciDersleri.Find(x => x.DersId == silinecekDers.Id);
                _db.OgrenciDerslers.Remove(silinecekOgrenciDers);
                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                silinecekDers = null;
                OgrenciDersleriGetir();

            }
            else
                MessageBox.Show("öğrenci seç");
        }
    }
}
