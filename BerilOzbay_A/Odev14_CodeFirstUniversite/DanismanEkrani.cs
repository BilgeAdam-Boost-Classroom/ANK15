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
    public partial class DanismanEkrani : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Danisman secilenDanisman;
        public DanismanEkrani()
        {
            InitializeComponent();
            DanismanlariGoster();

        }
        private void DanismanlariGoster()
        {
            dgvDanismanlar.DataSource = null;
            dgvDanismanlar.DataSource = _db.Danismans.ToList();
            if (dgvDanismanlar.Columns[0].Visible)
                dgvDanismanlar.Columns[0].Visible = false;
        }
        private void dgvDanismanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDanisman = (Danisman)dgvDanismanlar.SelectedRows[0].DataBoundItem;
            txtAdi.Text = secilenDanisman.Adi;
            txtSoyadi.Text = secilenDanisman.Soyadi;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Danisman danisman = new Danisman();
                danisman.Adi = txtAdi.Text;
                danisman.Soyadi = txtSoyadi.Text;

                _db.Danismans.Add(danisman);
                _db.SaveChanges();
                DanismanlariGoster();
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
                if (secilenDanisman != null)
                {
                    secilenDanisman.Adi = txtAdi.Text;
                    secilenDanisman.Soyadi = txtSoyadi.Text;

                    _db.SaveChanges();
                    DanismanlariGoster();
                    secilenDanisman = null;
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen danisman seçiniz");
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
                if (secilenDanisman != null)
                {
                    _db.Danismans.Remove(secilenDanisman);
                    _db.SaveChanges();

                    DanismanlariGoster();

                    secilenDanisman = null;
                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen danisman seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
