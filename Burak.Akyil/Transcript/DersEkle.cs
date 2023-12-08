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
    public partial class DersEkle : Form
    {
        public static List<Ders> dersler = new List<Ders>();
        Ders secilenDers;
        public DersEkle()
        {
            InitializeComponent();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Ad = txtDersAd.Text;
            ders.Kod = txtDersKod.Text;
            ders.Kredi = Convert.ToInt32(txtDersKredi.Text);
            dersler.Add(ders);
            dataGridDers.DataSource = null;
            dataGridDers.DataSource = dersler;
        }

        private void dataGridDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDers = (Ders)dataGridDers.Rows[e.RowIndex].DataBoundItem;
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                dersler.Remove(secilenDers);
                dataGridDers.DataSource = null;
                dataGridDers.DataSource = dersler;
            }
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if(secilenDers != null)
            {
                secilenDers.Ad = txtDersAd.Text;
                secilenDers.Kod = txtDersKod.Text;
                secilenDers.Kredi = Convert.ToInt32(txtDersKredi.Text);
                dataGridDers.DataSource = null;
                dataGridDers.DataSource = dersler;
            }
        }
    }
}
