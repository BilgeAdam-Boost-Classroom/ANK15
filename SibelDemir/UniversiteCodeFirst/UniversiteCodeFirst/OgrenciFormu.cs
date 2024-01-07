using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteCodeFirst
{

    public partial class OgrenciFormu : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Ogrenci secilenOgrenci;
        public OgrenciFormu()
        {
            InitializeComponent();
            OgrenciGoster();
            Doldur();
        }
        private void Doldur()
        {
            comboBox1.DataSource = _db.Danisman.ToList();
            comboBox2.DataSource = _db.Diplomalar.ToList();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void OgrenciGoster()
        {
            dgvOgrenci.DataSource = null;
            dgvOgrenci.DataSource = _db.Ogrenciler.ToList();
            if (dgvOgrenci.Columns[0].Visible)
                dgvOgrenci.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Numara = txtNumara.Text;
            ogrenci.DanismanId = ((Danisman)comboBox1.SelectedItem).Id;
            ogrenci.DiplomaId = ((Diploma)comboBox2.SelectedItem).Id;

            _db.Ogrenciler.Add(ogrenci);
            _db.SaveChanges();
            OgrenciGoster();
            MessageBox.Show("başarıyla eklenmiştir");
        }

        private void dgvOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = (Ogrenci)dgvOgrenci.SelectedRows[0].DataBoundItem;
            txtAd.Text = secilenOgrenci.Ad;
            txtSoyad.Text = secilenOgrenci.Soyad;
            txtNumara.Text = secilenOgrenci.Numara;
            comboBox1.SelectedItem = secilenOgrenci.Danisman.Ad;
            comboBox2.SelectedItem = secilenOgrenci.DiplomaId;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenOgrenci != null)
                {
                    secilenOgrenci.Ad = txtAd.Text;
                    secilenOgrenci.Soyad = txtSoyad.Text;
                    secilenOgrenci.Numara = txtNumara.Text;
                    secilenOgrenci.DanismanId = (int)comboBox1.SelectedItem;
                    secilenOgrenci.DiplomaId = (int)comboBox2.SelectedItem;

                    _db.SaveChanges();
                    OgrenciGoster();
                    secilenOgrenci = null;
                    //lblScilenDiploma.Text = "seçilen diploma";
                }
                else
                    MessageBox.Show("lütfen diploma seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Danisman secilenDanisman = (Danisman)comboBox1.SelectedItem;
            if (secilenOgrenci == null)
                return;
            if (!string.IsNullOrEmpty(secilenOgrenci.DanismanId.ToString()))
            {
                Danisman danisman = _db.Danisman.First(d => d.Id == secilenOgrenci.DanismanId);

            }

        }
    }
}
