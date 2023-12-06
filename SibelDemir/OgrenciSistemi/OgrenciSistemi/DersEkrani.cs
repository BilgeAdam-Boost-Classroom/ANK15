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
    public partial class DersEkrani : Form
    {
        List<Ders> dersler ;
        public DersEkrani(List<Ders> dersler)
        {
            InitializeComponent();
            this.dersler = dersler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Ad = txtAd.Text;
            ders.Kod = Convert.ToInt32(txtKod.Text);
            ders.Kredi = Convert.ToInt32(txtKredi.Text);
            dersler.Add(ders);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dersler;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var d = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            d.Ad = txtAd.Text;
            d.Kod = Convert.ToInt32(txtKod.Text);
            d.Kredi = Convert.ToInt32(txtKredi.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dersler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var d = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            dersler.Remove(d);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dersler;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var d = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            txtAd.Text = d.Ad;
            txtKod.Text = d.Kod.ToString();
            txtKredi.Text = d.Kredi.ToString();
        }
    }
}
