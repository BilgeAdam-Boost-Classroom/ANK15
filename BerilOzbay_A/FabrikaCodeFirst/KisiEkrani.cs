using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaCodeFirst
{
    public partial class KisiEkrani : Form
    {
        FabrikaDbContext _db = new FabrikaDbContext();
        Kisi secilenKisi;

        public KisiEkrani()
        {
            InitializeComponent();
            KisileriGoster();
        }
        private void KisileriGoster()
        {
            dgvKisiler.DataSource = null;
            dgvKisiler.DataSource = _db.Kisiler.ToList();
            if (dgvKisiler.Columns[0].Visible)
                dgvKisiler.Columns[0].Visible = false;
        }
        private void dgvKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKisi = (Kisi)dgvKisiler.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenKisi.Ad;
            txtSoyad.Text = secilenKisi.Soyad;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kisi kisi = new Kisi();
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                _db.Kisiler.Add(kisi);
                _db.SaveChanges();
                KisileriGoster();
                MessageBox.Show("Basari ile eklendi.");
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
                if (secilenKisi != null)
                {
                    secilenKisi.Ad = txtAd.Text;
                    secilenKisi.Soyad = txtSoyad.Text;

                    _db.SaveChanges();
                    KisileriGoster();
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen kisi seçiniz");
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
                if (secilenKisi != null)
                {
                    _db.Kisiler.Remove(secilenKisi);
                    _db.SaveChanges();
                    txtAd.Text = null;
                    txtSoyad.Text = null;

                    KisileriGoster();

                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen kisi seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
