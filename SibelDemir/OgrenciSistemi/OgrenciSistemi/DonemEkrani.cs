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
    public partial class DonemEkrani : Form
    {
        List<Donem> donemler ;
        public DonemEkrani(List<Donem> donemler)
        {
            InitializeComponent();
            this.donemler = donemler;
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            Donem donem = new Donem();
            donem.Ad = txtAd.Text;
            donem.No = Convert.ToInt32(txtNo.Text);
            donemler.Add(donem);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = donemler;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var d = (Donem)dataGridView1.SelectedRows[0].DataBoundItem;
            d.No = Convert.ToInt32(txtNo.Text);
            d.Ad = txtAd.Text;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = donemler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var d = (Donem)dataGridView1.SelectedRows[0].DataBoundItem;
            donemler.Remove(d);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = donemler;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var d = (Donem)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtAd.Text = d.Ad;
            txtNo.Text = d.No.ToString();
        }
    }
}
