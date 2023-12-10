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
    public partial class Transcript : Form
    {
        List<Ogrenci> ogrenciler;
        List<Donem> donemler;
        List<OgrenciDers> ogrenciDersleri;
        List<Ders> dersler;

        public Transcript(List<Ogrenci> ogrenciler, List<Donem> donemler, List<Ders> dersler)
        {
            InitializeComponent();
            this.ogrenciler = ogrenciler;
            this.donemler = donemler;
            cmbxTOgrenci.DataSource = ogrenciler;
            cmbxTDonem.DataSource = donemler;

            //dataGridView1.DataSource = ogrenciDersleri.ToList();
        }


        private void btnGoster_Click(object sender, EventArgs e)
        {
            double donemkredi = 0;
            double toplamkredi = 0;
            double donemortalamasi = 0;
            double genelOrtalama = 0;
            Donem selectedDonem = (Donem)cmbxTDonem.SelectedItem;
            Ogrenci selectedOgrenci = (Ogrenci)cmbxTOgrenci.SelectedItem;
            List<OgrenciDers> selectedOgrenciDonemDers = selectedOgrenci.OgrenciDersleri.FindAll(d => d.Donem.No == selectedDonem.No && d.Ogrenci == selectedOgrenci);

            List<OgrenciDers> selectedOgrenciDersleri = selectedOgrenci.OgrenciDersleri.FindAll(d => d.Ogrenci == selectedOgrenci);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = selectedOgrenciDonemDers;
            dataGridView1.DataSource = selectedOgrenciDersleri;

            foreach (var item in selectedOgrenciDonemDers)
            {
                donemkredi += item.Ders.Kredi;
                donemortalamasi += item.Ders.Kredi * (int)item.HarfNotu;
            }

            foreach (var item in selectedOgrenciDersleri)
            {

                toplamkredi += item.Ders.Kredi;
                

            }
            lblDonemKredisi.Text = donemkredi.ToString();
            lblToplamKredi.Text = toplamkredi.ToString();

            //lblDonemKredisi.Text=dersler.kr
        }
    }
}
