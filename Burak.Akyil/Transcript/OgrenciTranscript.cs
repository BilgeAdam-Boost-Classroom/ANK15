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
            foreach (var item in OgrenciDersEkle.ogrenciDersler)
            {
                if(item.Ogrenci == (Ogrenci)cbxOgrenci.SelectedItem && item.Donem == (Donem)cbxDonem.SelectedItem)
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
                Donem= ot.Donem.Ad 

            }).ToList();
        }
    }
}
