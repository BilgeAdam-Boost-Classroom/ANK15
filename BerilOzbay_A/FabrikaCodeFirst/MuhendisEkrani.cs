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
    public partial class MuhendisEkrani : Form
    {
        FabrikaDbContext _db = new FabrikaDbContext();
        Muhendis secilenMuhendis;
        public MuhendisEkrani()
        {
            InitializeComponent();
            MuhendisleriGoster();
        }
        private void MuhendisleriGoster()
        {
            dgvMuhendisler.DataSource = null;
            dgvMuhendisler.DataSource = _db.Muhendisler.ToList();
            if (dgvMuhendisler.Columns[0].Visible)
                dgvMuhendisler.Columns[0].Visible = false;
        }
        private void dgvMuhendisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenMuhendis = (Muhendis)dgvMuhendisler.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenMuhendis.Adi;
            txtSoyad.Text = secilenMuhendis.Soyad;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Muhendis muhendis = new Muhendis();
                muhendis.Adi = txtAd.Text;
                muhendis.Soyad = txtSoyad.Text;
                _db.Muhendisler.Add(muhendis);
                _db.SaveChanges();
                MuhendisleriGoster();
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
                if (secilenMuhendis != null)
                {
                    secilenMuhendis.Adi = txtAd.Text;
                    secilenMuhendis.Soyad = txtSoyad.Text;

                    _db.SaveChanges();
                    MuhendisleriGoster();
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen muhendis seçiniz");
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
                if (secilenMuhendis != null)
                {
                    _db.Muhendisler.Remove(secilenMuhendis);
                    _db.SaveChanges();
                    txtAd.Text = null;
                    txtSoyad.Text = null;

                    MuhendisleriGoster();

                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen muhendis seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
