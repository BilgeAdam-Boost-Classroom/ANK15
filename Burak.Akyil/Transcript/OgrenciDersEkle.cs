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
    public partial class OgrenciDersEkle : Form
    {
        public static List<OgrenciDers> ogrenciDersler = new List<OgrenciDers>();
        OgrenciDers secilenOgrenciDers;
        public OgrenciDersEkle()
        {
            InitializeComponent();
            cbxOgrenci.DataSource = OgrenciEkleSil.ogrenciler;
            cbxDers.DataSource = DersEkle.dersler;
            cbxDonem.DataSource = DonemEkle.donemler;
            cbxHarfNotu.DataSource = Enum.GetValues(typeof(HarfNotu));
        }

        private void btnOgrenciDersEkle_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrenciDers = new OgrenciDers();
            ogrenciDers.Ogrenci = (Ogrenci)cbxOgrenci.SelectedItem;
            ogrenciDers.Ders = (Ders)cbxDers.SelectedItem;
            ogrenciDers.Donem = (Donem)cbxDonem.SelectedItem;
            ogrenciDers.HarfNotu = (HarfNotu)Enum.Parse(typeof(HarfNotu), cbxHarfNotu.Text);
            ogrenciDersler.Add(ogrenciDers);
            dataGridOgrenciDers.DataSource = null;
            dataGridOgrenciDers.DataSource = ogrenciDersler;

        }

        private void dataGridOgrenciDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenciDers = (OgrenciDers)dataGridOgrenciDers.Rows[e.RowIndex].DataBoundItem;
        }
        private void btnOgrenciDersCıkar_Click(object sender, EventArgs e)
        {
            if(secilenOgrenciDers != null)
            {
                ogrenciDersler.Remove(secilenOgrenciDers);
                dataGridOgrenciDers.DataSource = null;
                dataGridOgrenciDers.DataSource = ogrenciDersler;
            }
        }

    }
}
