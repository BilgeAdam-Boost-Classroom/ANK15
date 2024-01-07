using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabamDb_codeFirst
{
    public partial class MuhendisFormu : Form
    {
        ArabamDbContext _db = new ArabamDbContext();
        Muhendis secilenMuhendis;

        public MuhendisFormu()
        {
            InitializeComponent();
            Goster();
        }
        private void Goster()
        {
            dgvMuhendis.DataSource = null;
            dgvMuhendis.DataSource = _db.Muhendisler.ToList();
            if (dgvMuhendis.Columns[0].Visible)
                dgvMuhendis.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Muhendis muhendis = new Muhendis();
                muhendis.Ad = txtAd.Text;
                muhendis.Soyad = txtSoyad.Text;

                _db.Muhendisler.Add(muhendis);
                _db.SaveChanges();
                Goster();
                MessageBox.Show("başarıyla eklenmiştir");

            }
            catch (Exception)
            {


            }
        }

        private void dgvMuhendis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenMuhendis = (Muhendis)dgvMuhendis.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenMuhendis.Ad;
            txtSoyad.Text = secilenMuhendis.Soyad;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenMuhendis != null)
                {
                    secilenMuhendis.Ad = txtAd.Text;
                    secilenMuhendis.Soyad = txtSoyad.Text;

                    _db.SaveChanges();
                    Goster();
                    secilenMuhendis = null;
                    // lblScilenDiploma.Text = "seçilen diploma";
                }
                else
                    MessageBox.Show("lütfen seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenMuhendis != null)
            {
                _db.Muhendisler.Remove(secilenMuhendis);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenMuhendis = null;
                //label3.Text = "Seçilen Ders:";
                Goster();

            }
            else
                MessageBox.Show("seç");
        }
    }
}
