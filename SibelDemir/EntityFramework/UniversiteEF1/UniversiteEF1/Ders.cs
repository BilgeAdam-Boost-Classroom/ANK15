using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteEF1.Models;

namespace UniversiteEF1
{
    public partial class Ders : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Dersler secilenDers;
        public Ders()
        {
            InitializeComponent();
            Goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad, kod, kredi;
            ad = txtAd.Text;
            kod = txtKod.Text;
            kredi = txtKredi.Text;

            Dersler ders = new Dersler();
            ders.Ad = ad;
            ders.Kod = kod;
            ders.Kredi = Convert.ToInt32(kredi);
            _db.Derslers.Add(ders);
            _db.SaveChanges();
            Goster();
            MessageBox.Show("veritabanına eklenmiştir");
        }
        private void Goster()
        {
            dGWDers.DataSource = null;
            dGWDers.DataSource = _db.Derslers.ToList()
;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                secilenDers.Ad = txtAd.Text;
                secilenDers.Kod = txtKod.Text;
                secilenDers.Kredi = Convert.ToInt32(txtKredi.Text);

                _db.SaveChanges();
                MessageBox.Show("başarıyla güncellenmiştir");
                secilenDers = null;
                label3.Text = "Seçilen Ders:";
                Goster();

            }
            else
                MessageBox.Show("ders seç");
        }

        private void dGWDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGWDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDers = (Dersler)dGWDers.SelectedRows[0].DataBoundItem; //satırdaki tıklanan
            txtAd.Text = secilenDers.Ad;
            txtKod.Text = secilenDers.Kod;
            txtKredi.Text = secilenDers.Kredi.ToString();


            label3.Text = "Seçilen Ders:" + secilenDers.Ad + " " + secilenDers.Kod + " " + secilenDers.Kredi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                _db.Derslers.Remove(secilenDers);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenDers = null;
                label3.Text = "Seçilen Ders:";
                Goster();

            }
            else
                MessageBox.Show("ders seç");
        }
    }
}
