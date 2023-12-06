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
        List<OgrenciDers> ogrenciDersleri ;

        public Transcript(List<Ogrenci> ogrenciler, List<Donem> donemler)
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
            Donem selectedDonem = (Donem)cmbxTDonem.SelectedItem;
            Ogrenci selectedOgrenci = (Ogrenci)cmbxTOgrenci.SelectedItem;
            List<OgrenciDers> selectedOgrenciDers = selectedOgrenci.OgrenciDersleri.FindAll(d => d.Donem.No == selectedDonem.No);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = selectedOgrenciDers;
        }
    }
}
