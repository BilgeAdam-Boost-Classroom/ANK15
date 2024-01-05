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
    public partial class OgrenciDersEkrani : Form
    {
        OkulDbContext _db = new OkulDbContext();
        OgrenciDers secilenOgrenciDers;
        List<int> notListesi = Enumerable.Range(0, 101).ToList();

        public OgrenciDersEkrani()
        {
            InitializeComponent();
            cbxOgrenci.DataSource = _db.Ogrencis.ToList();
            cbxDers.DataSource = _db.Dersler.ToList();
            cbxNot.DataSource = notListesi;
        }
        private void OgrenciDersleriGoster()
        {
            dgvOgrenciDers.DataSource = null;
            dgvOgrenciDers.DataSource = _db.OgrenciDers.ToList();
            if (dgvOgrenciDers.Columns[0].Visible)
                dgvOgrenciDers.Columns[0].Visible = false;
        }

        private void dgvOgrenciDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenciDers = (OgrenciDers)dgvOgrenciDers.SelectedRows[0].DataBoundItem;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciDers ogrenciDers = new OgrenciDers();
                ogrenciDers.DersId = ((Ders)cbxDers.SelectedItem).Id;
                ogrenciDers.OgrenciId = ((Ogrenci)cbxOgrenci.SelectedItem).Id;
                ogrenciDers.Not = (int)cbxNot.SelectedItem;

                _db.OgrenciDers.Add(ogrenciDers);
                _db.SaveChanges();
                OgrenciDersleriGoster();
                MessageBox.Show("Başarı ile eklendi.");
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
                if (secilenOgrenciDers != null)
                {
                    _db.OgrenciDers.Remove(secilenOgrenciDers);
                    _db.SaveChanges();
                    OgrenciDersleriGoster();
                    secilenOgrenciDers = null;
                    MessageBox.Show("Başari ile silinmiştir");
                }

                else
                {
                    MessageBox.Show("Lutfen Ogrenci-Ders seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
