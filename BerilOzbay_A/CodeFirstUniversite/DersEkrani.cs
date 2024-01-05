using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstUniversite
{
    public partial class DersEkrani : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Ders secilenDers;
        public DersEkrani()
        {
            InitializeComponent();
            DersleriGoster();
        }

        private void DersleriGoster()
        {
            dgvDersler.DataSource = null;
            dgvDersler.DataSource = _db.Dersler.ToList();
            if (dgvDersler.Columns[0].Visible)
                dgvDersler.Columns[0].Visible = false;
        }
        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            txtAdi.Text = secilenDers.Adi;
            txtKodu.Text = secilenDers.Kodu;
            txtKredi.Text = secilenDers.Kredi.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ders ders = new Ders();
                ders.Adi = txtAdi.Text;
                ders.Kodu = txtKodu.Text;
                ders.Kredi = Convert.ToInt32(txtKredi.Text);

                _db.Dersler.Add(ders);
                _db.SaveChanges();
                DersleriGoster();
                MessageBox.Show("Başarı ile eklendi.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDers != null)
                {
                    secilenDers.Adi = txtAdi.Text;
                    secilenDers.Kodu = txtKodu.Text;
                    secilenDers.Kredi = Convert.ToInt32(txtKredi.Text);

                    _db.SaveChanges();
                    DersleriGoster();
                    secilenDers = null;
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen ders seçiniz");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDers != null)
                {
                    _db.Dersler.Remove(secilenDers);
                    _db.SaveChanges();

                    DersleriGoster();

                    secilenDers = null;
                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen ders seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
