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
    public partial class PlakaEkrani : Form
    {
        FabrikaDbContext _db = new FabrikaDbContext();
        Plaka secilenPlaka;
        public PlakaEkrani()
        {
            InitializeComponent();
            PlakalariGoster();

        }
        private void PlakalariGoster()
        {
            dgvPlakalar.DataSource = null;
            dgvPlakalar.DataSource = _db.Plakalar.ToList();
            if (dgvPlakalar.Columns[0].Visible)
                dgvPlakalar.Columns[0].Visible = false;

        }
        private void dgvPlakalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenPlaka = (Plaka)dgvPlakalar.SelectedRows[0].DataBoundItem;
            txtKod.Text = secilenPlaka.Kodu;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Plaka plaka = new Plaka();
                plaka.Kodu = txtKod.Text;
                _db.Plakalar.Add(plaka);
                _db.SaveChanges();
                PlakalariGoster();
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
                if (secilenPlaka != null)
                {
                    secilenPlaka.Kodu = txtKod.Text;

                    _db.SaveChanges();
                    PlakalariGoster();
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen plaka seçiniz");
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
                if (secilenPlaka != null)
                {
                    _db.Plakalar.Remove(secilenPlaka);
                    _db.SaveChanges();
                    txtKod.Text = null;

                    PlakalariGoster();

                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen plaka seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
