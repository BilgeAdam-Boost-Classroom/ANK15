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
    public partial class OgrenciEkrani : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Ogrenci secilenOgrenci;
        

        public OgrenciEkrani()
        {
            InitializeComponent();
            OgrencileriGoster();
            cbxDanisman.DataSource = _db.Danismans.ToList();
            cbxDiploma.DataSource = _db.Diplomas.ToList();
        }
        private void OgrencileriGoster()
        {
            dgvOgrenciler.DataSource = null;
            dgvOgrenciler.DataSource = _db.Ogrencis.ToList();
            if (dgvOgrenciler.Columns[0].Visible)
                dgvOgrenciler.Columns[0].Visible = false;
        }
        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
            txtAdi.Text = secilenOgrenci.Adı;
            txtSoyadi.Text = secilenOgrenci.Soyadı;
            txtNumara.Text = secilenOgrenci.Numara;
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Adı = txtAdi.Text;
                ogrenci.Soyadı = txtSoyadi.Text;
                ogrenci.Numara = txtNumara.Text;
                ogrenci.DanismanId = ((Danisman)cbxDanisman.SelectedItem).Id;
                ogrenci.DiplomaYabanciAnahtar = ((Diploma)cbxDiploma.SelectedValue).DiplomaBirincilAnahtar;

                _db.Ogrencis.Add(ogrenci);
                _db.SaveChanges();
                OgrencileriGoster();
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
                if (secilenOgrenci != null)
                {
                    secilenOgrenci.Adı = txtAdi.Text;
                    secilenOgrenci.Soyadı = txtSoyadi.Text;
                    secilenOgrenci.Numara = txtNumara.Text;
                    secilenOgrenci.DanismanId = ((Danisman)cbxDanisman.SelectedItem).Id;
                    secilenOgrenci.DiplomaYabanciAnahtar = ((Diploma)cbxDiploma.SelectedValue).DiplomaBirincilAnahtar;

                    _db.SaveChanges();
                    OgrencileriGoster();
                    secilenOgrenci = null;
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen ogrenci seçiniz");
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
                if (secilenOgrenci != null)
                {
                    _db.Ogrencis.Remove(secilenOgrenci);
                    _db.SaveChanges();

                    OgrencileriGoster();

                    secilenOgrenci = null;
                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen ogrenci seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
