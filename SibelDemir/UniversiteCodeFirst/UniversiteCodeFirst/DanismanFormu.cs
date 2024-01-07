using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteCodeFirst
{
    public partial class DanismanFormu : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Danisman secilenDanisman;
        public DanismanFormu()
        {
            InitializeComponent();
            DanismanlariGoster();
        }
        private void DanismanlariGoster()
        {
            dgvDanisman.DataSource = null;
            dgvDanisman.DataSource = _db.Danisman.ToList();
            if (dgvDanisman.Columns[0].Visible)
                dgvDanisman.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Danisman danisman = new Danisman();
                danisman.Ad = txtAd.Text;
                danisman.Soyad = txtSoyad.Text;

                _db.Danisman.Add(danisman);
                _db.SaveChanges();
                DanismanlariGoster();
                MessageBox.Show("başariyla eklenmiştir");
            }
            catch (Exception)
            {


            }
        }

        private void dgvDanisman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDanisman = (Danisman)dgvDanisman.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenDanisman.Ad;
            txtSoyad.Text = secilenDanisman.Soyad;

            lblSecilenDanisman.Text = "Seçilen Danışman:" + secilenDanisman.Ad + " " + secilenDanisman.Soyad;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenDanisman != null)
            {
                secilenDanisman.Ad = txtAd.Text;
                secilenDanisman.Soyad = txtSoyad.Text;

                _db.SaveChanges();
                MessageBox.Show("başarıyla güncellenmiştir");
                secilenDanisman = null;
                //secilenDanisman.Text = "Seçilen Danışman:";
                DanismanlariGoster();

            }
            else
                MessageBox.Show("danışman seç");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenDanisman != null)
            {
                _db.Danisman.Remove(secilenDanisman);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenDanisman = null;
                //secilenDanisman.Text = "Seçilen Danışman:";
                DanismanlariGoster();

            }
            else
                MessageBox.Show("danışman seç");
        }
    }
}
