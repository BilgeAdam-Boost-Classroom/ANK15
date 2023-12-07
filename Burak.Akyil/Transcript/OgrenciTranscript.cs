using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transcript
{
    public partial class OgrenciTranscript : Form
    {
        public List<OgrenciDers> filtreliListe = new List<OgrenciDers>();
        public OgrenciTranscript()
        {
            InitializeComponent();
            cbxOgrenci.DataSource = OgrenciEkleSil.ogrenciler;
            cbxDonem.DataSource = DonemEkle.donemler;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            double donemKredi = 0;
            double toplamKredi = 0;
            double donemOrtalaması = 0;
            double genelOrtalama = 0;
            foreach (var item in OgrenciDersEkle.ogrenciDersler)
            {
                if (item.Ogrenci == (Ogrenci)cbxOgrenci.SelectedItem && item.Donem == (Donem)cbxDonem.SelectedItem)
                {
                    filtreliListe.Add(item);
                }
            }
            dataGridTranscript.DataSource = filtreliListe.Select(ot => new
            {
                DersAd = ot.Ders.Ad,
                DersKod = ot.Ders.Kod,
                DersKredi = ot.Ders.Kredi,
                DersHarfNotu = ot.HarfNotu.ToString(),
                Donem = ot.Donem.Ad

            }).ToList();
            foreach (var item in filtreliListe)
            {
                if (item.Ogrenci == (Ogrenci)cbxOgrenci.SelectedItem)
                {
                    donemKredi += item.Ders.Kredi;
                    donemOrtalaması += item.Ders.Kredi * (int)item.HarfNotu / 10.0;
                }
            }
            donemOrtalaması = donemOrtalaması / donemKredi;
            foreach (var item in OgrenciDersEkle.ogrenciDersler)
            {
                if (item.Ogrenci == (Ogrenci)cbxOgrenci.SelectedItem)
                {
                    toplamKredi += item.Ders.Kredi;
                    genelOrtalama += item.Ders.Kredi * ((int)item.HarfNotu / 10.0);
                }
            }
            genelOrtalama = genelOrtalama / toplamKredi;

            lblDonemKredisi.Text = "Dönem Kredisi: " + donemKredi.ToString();
            lblToplamKredi.Text = "Toplam Kredi: " + toplamKredi.ToString();
            lblDonemOrtalaması.Text = "Dönem Ortalaması: " + donemOrtalaması.ToString();
            lblGenelOrtalaması.Text = "Genel Ortalaması: " + genelOrtalama.ToString();
        }
    }
}


