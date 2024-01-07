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
    public partial class SahipFormu : Form
    {
        ArabamDbContext _db = new ArabamDbContext();
        Sahip secilenSahip;

        public SahipFormu()
        {
            InitializeComponent();
            Goster();
        }
        private void Goster()
        {
            dgvSahip.DataSource = null;
            dgvSahip.DataSource = _db.Sahipler.ToList();
            if (dgvSahip.Columns[0].Visible)
                dgvSahip.Columns[0].Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenSahip != null)
                {
                    secilenSahip.Ad = txtAd.Text;
                    secilenSahip.Soyad = txtSoyad.Text;

                    _db.SaveChanges();
                    Goster();
                    secilenSahip = null;
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Sahip sahip = new Sahip();
                sahip.Ad = txtAd.Text;
                sahip.Soyad = txtSoyad.Text;


                _db.Sahipler.Add(sahip);
                _db.SaveChanges();
                Goster();
                MessageBox.Show("başarıyla eklenmiştir");

            }
            catch (Exception)
            {


            }
        }

        private void dgvSahip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSahip = (Sahip)dgvSahip.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenSahip.Ad;
            txtSoyad.Text = secilenSahip.Soyad;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenSahip != null)
            {
                _db.Sahipler.Remove(secilenSahip);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenSahip = null;
                //label3.Text = "Seçilen Ders:";
                Goster();

            }
            else
                MessageBox.Show(" seç");
        }
    }
}
