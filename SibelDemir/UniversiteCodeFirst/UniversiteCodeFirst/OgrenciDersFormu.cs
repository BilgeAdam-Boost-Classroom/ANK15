using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversiteCodeFirst
{
    public partial class OgrenciDersFormu : Form
    {
        OkulDbContext _db = new OkulDbContext();
        OgrenciDers secilenOgrenciDers;
        public OgrenciDersFormu()
        {
            InitializeComponent();
            //OgrenciDersGoster();
        }
        private void Doldur()
        {
            cmbOgrenci.DataSource = _db.Ogrenciler.ToList();
            cmbDers.DataSource = _db.Dersler.ToList();
            cmbOgrenci.SelectedIndex = -1;
            cmbDers.SelectedIndex = -1;
        }
        private void OgrenciDersGoster()
        {
            dgvOD.DataSource = null;
            List<OgrenciDers>ogrenciDersler = _db.OgrenciDersler.ToList();
            Ogrenci secilenOgrenci =cmbOgrenci.SelectedItem as Ogrenci;
            List<OgrenciDers> secilenOgrenciDersler = ogrenciDersler.Where(s => s.OgrenciId == secilenOgrenci.Id).ToList();
            dgvOD.DataSource = secilenOgrenciDersler;

            if (dgvOD.Columns[0].Visible)
                dgvOD.Columns[0].Visible = false;
        }

        private void OgrenciDersFormu_Load(object sender, EventArgs e)
        {
            Doldur();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrenciDers = new OgrenciDers();
            ogrenciDers.OgrenciId = ((Ogrenci)cmbOgrenci.SelectedItem).Id;
            ogrenciDers.DersId = ((Ders)cmbDers.SelectedItem).Id;

            _db.OgrenciDersler.Add(ogrenciDers);
            _db.SaveChanges();
            OgrenciDersGoster();
            MessageBox.Show("başarıyla eklenmiştir");
        }

        private void dgvOD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenciDers = (OgrenciDers)dgvOD.SelectedRows[0].DataBoundItem;

            cmbOgrenci.SelectedItem = secilenOgrenciDers.Ogrenci.Ad;
            cmbDers.SelectedItem = secilenOgrenciDers.Ders.Ad;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOgrenciDers != null)
            {
                _db.OgrenciDersler.Remove(secilenOgrenciDers);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenOgrenciDers = null;
                //label3.Text = "Seçilen Ders:";
                OgrenciDersGoster();

            }
            else
                MessageBox.Show("seçim yapınız");
        }

        private void cmbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci secilenOgrenci = (Ogrenci)cmbOgrenci.SelectedItem;
            if (secilenOgrenci == null)
                return;


        }
    }
}
