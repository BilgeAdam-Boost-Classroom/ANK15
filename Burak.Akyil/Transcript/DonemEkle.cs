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
    public partial class DonemEkle : Form
    {
        public static List<Donem> donemler = new List<Donem>();
        Donem secilenDonem;
        public DonemEkle()
        {
            InitializeComponent();
        }

        private void btnDonemEkle_Click(object sender, EventArgs e)
        {
            Donem donem = new Donem();
            donem.Ad = txtDonemAd.Text;
            donem.No = Convert.ToInt32(txtDonemNo.Text);
            donemler.Add(donem);
            dataGridDonem.DataSource = null;
            dataGridDonem.DataSource = donemler;
        }
        private void dataGridDonem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDonem = (Donem)dataGridDonem.Rows[e.RowIndex].DataBoundItem;
        }

        private void btnDonemSil_Click(object sender, EventArgs e)
        {
            if (secilenDonem != null)
            {
                donemler.Remove(secilenDonem);
                dataGridDonem.DataSource = null;
                dataGridDonem.DataSource = donemler;
            }
        }

        private void btnDonemGuncelle_Click(object sender, EventArgs e)
        {
            if(secilenDonem != null)
            {
                secilenDonem.Ad = txtDonemAd.Text;
                secilenDonem.No = Convert.ToInt32(txtDonemNo.Text);
                dataGridDonem.DataSource = null;
                dataGridDonem.DataSource = donemler;
            }
        }
    }
}
