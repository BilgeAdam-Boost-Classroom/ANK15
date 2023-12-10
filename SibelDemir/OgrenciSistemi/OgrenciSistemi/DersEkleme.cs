using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OgrenciSistemi
{
    public partial class DersEkleme : Form
    {
        List<Donem> donemler;
        List<Ogrenci> ogrenciler;
        List<OgrenciDers> ogrenciDersleri=new List<OgrenciDers>();
        List<Ders>dersler= new List<Ders>();

        public DersEkleme(List<Ogrenci> ogrenciler, List<Ders> dersler, List<Donem> donemler)
        {
            InitializeComponent();
            this.ogrenciler = ogrenciler;
            this.donemler = donemler;
            this.dersler = dersler;
            cmbxOgrenci.DataSource = ogrenciler;
            cmbxDonem.DataSource = donemler;
            cmbxDers.DataSource = dersler;
            cmbxHarfNotu.DataSource = Enum.GetValues(typeof(HarfNotu));
        }
        private void DersEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnOgreciyeDersEkle_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrenciDers = new OgrenciDers();
            Ogrenci secilenOgrenci = (Ogrenci)cmbxOgrenci.SelectedItem;
            ogrenciDers.Ogrenci= secilenOgrenci;
            ogrenciDers.Donem = (Donem)cmbxDonem.SelectedItem;
            ogrenciDers.Ders = (Ders)cmbxDers.SelectedItem;
            ogrenciDers.HarfNotu = (HarfNotu)cmbxHarfNotu.SelectedItem;
            ogrenciDersleri.Add(ogrenciDers);
            secilenOgrenci.OgrenciDersleri = ogrenciDersleri;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciDersleri.ToList();
            MessageBox.Show("öğrenciye ders eklenmiştir");

        }
        private void btnOgrencidenDersCikar_Click(object sender, EventArgs e)
        {
            OgrenciDers secilenDers = (OgrenciDers)dataGridView1.SelectedRows[0].DataBoundItem;
            ogrenciDersleri.Remove(secilenDers);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciDersleri.ToList();
            MessageBox.Show("öğrenciden ders çıkarıldı");

        }
        private void btnTranscriptGor_Click(object sender, EventArgs e)
        {
            Transcript transcript = new Transcript(ogrenciler,donemler,dersler);
            transcript.Show();
                        
        }
    }
}
