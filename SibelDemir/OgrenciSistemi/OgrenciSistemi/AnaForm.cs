using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSistemi
{
    public partial class AnaForm : Form
    {
        
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        static List<Ders> dersler = new List<Ders>();
        static List<Donem> donemler = new List<Donem>();


        public AnaForm()
        {
            InitializeComponent();
        }
        private void FormGoster(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;//hep aynı konumda açılması için form.
            if (!MdiChildren.Contains(gosterilecekForm))
            {
                gosterilecekForm.MdiParent = this;
            }
            //bu form çocukları içerisinde dönelim. İstenileni görünür yapalım.
            foreach (Form altForm in MdiChildren)
            {
                if (gosterilecekForm.Text == altForm.Text)
                {
                    altForm.Show();
                }
                else
                {
                    altForm.Close();
                }
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci() { Numara = 1, Ad = "Sibel" };
            Ders ders = new Ders() { Ad = "Mat1", Kod = 1, Kredi = 10 };
            Donem donem = new Donem() {Ad="Güz",No=123 };
            OgrenciDers ogrenciDers = new OgrenciDers() { Ders = ders, HarfNotu = HarfNotu.DC ,Donem= donem };
            ogrenci.OgrenciDersleri = new List<OgrenciDers>();
            ogrenci.OgrenciDersleri.Add(ogrenciDers);
            ogrenciler.Add(ogrenci);
            dersler.Add(ders);
            donemler.Add(donem);

        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciEkrani(ogrenciler));
        }

        private void dersEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkrani(dersler));
        }

        private void donemEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DonemEkrani(donemler));
        }

        private void dersEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkleme(ogrenciler,dersler,donemler));
        }

        private void transcriptGorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new Transcript(ogrenciler,donemler,dersler));
        }
    }
}
