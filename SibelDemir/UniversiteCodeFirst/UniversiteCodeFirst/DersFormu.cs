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
    public partial class DersFormu : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Ders secilenDers;

        public DersFormu()
        {
            InitializeComponent();
            DersleriGoster();
        }

        private void DersleriGoster()
        {
            dgvDers.DataSource = null;
            dgvDers.DataSource = _db.Dersler.ToList();
            if (dgvDers.Columns[0].Visible)
                dgvDers.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ders ders = new Ders();
                ders.Ad = txtAd.Text;
                ders.Kod = txtKod.Text;
                ders.Kredi = Convert.ToInt32(txtKredi.Text);

                _db.Dersler.Add(ders);
                _db.SaveChanges();
                DersleriGoster();
                MessageBox.Show("başarıyla eklenmiştir");

            }
            catch (Exception)
            {


            }
        }

        private void dgvDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDers = (Ders)dgvDers.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenDers.Ad;
            txtKod.Text = secilenDers.Kod;
            txtKredi.Text = secilenDers.Kredi.ToString();

            //lblScilenDiploma.Text = secilenDiploma.No;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDers != null)
                {
                    secilenDers.Ad = txtAd.Text;
                    secilenDers.Kod = txtKod.Text;
                    secilenDers.Kredi = Convert.ToInt32(txtKredi.Text);

                    _db.SaveChanges();
                    DersleriGoster();
                    secilenDers = null;
                    // lblScilenDiploma.Text = "seçilen diploma";
                }
                else
                    MessageBox.Show("lütfen ders seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                _db.Dersler.Remove(secilenDers);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenDers = null;
                label3.Text = "Seçilen Ders:";
                DersleriGoster();

            }
            else
                MessageBox.Show("ders seç");
        }
    }
}
