using ANK15Okul.Concrete;
using ANK15Okul.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK15Okul
{
    public partial class OgrenciEkranForm : Form
    {
        private readonly Ank15OkulDbContext _db;
        Ogrenci secilenOgrenci;
        OgrenciDers secilenOgrenciDers;

        public OgrenciEkranForm(Ank15OkulDbContext db)
        {
            InitializeComponent();
            _db = db;
            DanismanlariDiplomalariGetir();
            OgrencileriGoster();
            DersleriGoster();
            NotlariGetir();
            OgrenciDersleriGoster();

        }

        private void OgrenciDersleriGoster()
        {
            dgvOgrenciDersler.DataSource = null;
            dgvOgrenciDersler.DataSource = _db.OgrenciDersler.ToList();
        }

        private void NotlariGetir()
        {
            cmbNotlar.Items.Add("Seçiniz");
            for (int i = 0; i <= 100; i++)
                cmbNotlar.Items.Add(i);

            cmbNotlar.SelectedIndex = 0;




        }
        private void DanismanlariDiplomalariGetir()
        {
            cmbOgrenciDanismani.Items.Add("Seçiniz");
            foreach (var item in _db.Danismanlar)
                cmbOgrenciDanismani.Items.Add(item);


            cmbOgrenciDiplomasi.Items.Add("Seçiniz");
            foreach (var item in _db.Diplomalar)
                cmbOgrenciDiplomasi.Items.Add(item);

            cmbOgrenciDanismani.SelectedIndex = cmbOgrenciDiplomasi.SelectedIndex = 0;
        }

        private void OgrencileriGoster()
        {
            var ogrenciler = _db.Ogrenciler;
            dgvOgrenciler.DataSource = null;
            dgvOgrenciler.DataSource = ogrenciler.ToList();

            cmbOgrenciler.Items.Clear();
            cmbOgrenciler.Items.Add("Seçiniz");
            cmbOgrenciler.SelectedIndex = 0;

            foreach (var item in ogrenciler)
                cmbOgrenciler.Items.Add(item);

        }

        private void DersleriGoster()
        {


            cmbDersler.Items.Clear();
            cmbDersler.Items.Add("Seçiniz");
            cmbDersler.SelectedIndex = 0;
            foreach (var item in _db.Dersler)
                cmbDersler.Items.Add(item);
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {

            try
            {

                if (_db.Ogrenciler.Any(o => o.DiplomaYabanciAnahtar == ((Diploma)(cmbOgrenciDiplomasi.SelectedItem)).DiplomaBirincilAnahtar))
                {
                    MessageBox.Show("Seçtğiniz diploma başkasına aittir.Lütfen başka seçiniz!");
                    return;
                }

                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ad = txtOgrenciAd.Text;
                ogrenci.Soyad = txtOgrenciSoyad.Text;
                ogrenci.Numara = txtOgrenciNo.Text;
                var seciliDanisman = ((Danisman)cmbOgrenciDanismani.SelectedItem);
                ogrenci.DanismanId = seciliDanisman.Id;
                var seciliDiploma = ((Diploma)cmbOgrenciDiplomasi.SelectedItem);
                ogrenci.DiplomaYabanciAnahtar = seciliDiploma.DiplomaBirincilAnahtar;

                _db.Ogrenciler.Add(ogrenci);
                _db.SaveChanges();
                OgrencileriGoster();

                MessageBox.Show("Öğrenci başarıyla eklenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenOgrenci != null)
                {

                    _db.Ogrenciler.Remove(secilenOgrenci);
                    _db.SaveChanges();
                    OgrencileriGoster();

                    secilenOgrenci = null;
                    lblSecilenOgrenci.Text = "Seçilen Öğrenci: ";
                    MessageBox.Show("Başarılı bir şekilde silinmiştir.");


                }
                else
                    MessageBox.Show("Öğrenci seçiniz");



            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenOgrenci = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
                txtOgrenciAd.Text = secilenOgrenci.Ad;
                txtOgrenciSoyad.Text = secilenOgrenci.Soyad;
                txtOgrenciNo.Text = secilenOgrenci.Numara;
                cmbOgrenciDanismani.SelectedItem = secilenOgrenci.Danisman;
                cmbOgrenciDiplomasi.SelectedItem = secilenOgrenci.Diploma;

                lblSecilenOgrenci.Text = "Seçilen Öğrenci: " + secilenOgrenci.Ad + " " + secilenOgrenci.Soyad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenOgrenci != null)
                {
                    List<Ogrenci> secileninListesi = new List<Ogrenci>();
                    //secileninListesi.Add(secilenOgrenci);
                    //if (_db.Ogrenciler.ToList().Except(secileninListesi).Any(o => o.DiplomaId == ((Diploma)(cmbOgrenciDiplomasi.SelectedItem)).Id))

                    bool kosul1 = _db.Ogrenciler.Any(o => o.DiplomaYabanciAnahtar == ((Diploma)(cmbOgrenciDiplomasi.SelectedItem)).DiplomaBirincilAnahtar);
                    bool kosul2 = (((Diploma)(cmbOgrenciDiplomasi.SelectedItem)).DiplomaBirincilAnahtar != secilenOgrenci.DiplomaYabanciAnahtar);
                    if (kosul1 && kosul2)
                    {
                        MessageBox.Show("Seçtğiniz diploma başkasına aittir.Lütfen başka seçiniz!");
                        return;
                    }

                    secilenOgrenci.Ad = txtOgrenciAd.Text;
                    secilenOgrenci.Soyad = txtOgrenciSoyad.Text;
                    secilenOgrenci.Numara = txtOgrenciNo.Text;
                    var seciliDanisman = ((Danisman)cmbOgrenciDanismani.SelectedItem);
                    secilenOgrenci.DanismanId = seciliDanisman.Id;
                    var seciliDiploma = ((Diploma)cmbOgrenciDiplomasi.SelectedItem);
                    secilenOgrenci.DiplomaYabanciAnahtar = seciliDiploma.DiplomaBirincilAnahtar;
                    _db.SaveChanges();
                    OgrencileriGoster();

                    secilenOgrenci = null;
                    lblSecilenOgrenci.Text = "Seçilen Öğrenci: ";
                    MessageBox.Show("Başarılı bir şekilde güncellenmiştir.");


                }
                else
                    MessageBox.Show("Öğrenci seçiniz");



            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnOdEkle_Click(object sender, EventArgs e)
        {
            try
            {

                OgrenciDers ogrenciDers = new OgrenciDers();
                ogrenciDers.OgrenciId = ((Ogrenci)(cmbOgrenciler.SelectedItem)).OgrenciBirincilAnahtar;
                ogrenciDers.DersId = ((Ders)(cmbDersler.SelectedItem)).Id;
                ogrenciDers.Not = Convert.ToInt32(cmbNotlar.Text);

                _db.OgrenciDersler.Add(ogrenciDers);
                _db.SaveChanges();
                OgrenciDersleriGoster();
                MessageBox.Show("Başarıyla öğrenciye ders eklenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnOdSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenOgrenciDers != null)
                {
                    _db.OgrenciDersler.Remove(secilenOgrenciDers);
                    _db.SaveChanges();
                    OgrenciDersleriGoster();
                    secilenOgrenciDers = null;
                    lblSecilenOgrenciDersi.Text = "Seçilen Öğrenci Dersi";
                    MessageBox.Show("Öğrenci dersi silinmiştir");
                }
                else
                    MessageBox.Show("Öğrenci dersi seçiniz");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvOgrenciDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenciDers = (OgrenciDers)dgvOgrenciDersler.SelectedRows[0].DataBoundItem;
            cmbDersler.SelectedItem = secilenOgrenciDers.Ders;
            cmbNotlar.SelectedItem = secilenOgrenciDers.Not;
            cmbOgrenciler.SelectedItem = secilenOgrenciDers.Ogrenci;

            lblSecilenOgrenciDersi.Text = "Seçilen Öğrenci Dersi: " + Environment.NewLine +
                secilenOgrenciDers.Ogrenci.Ad + " " + secilenOgrenciDers.Ogrenci.Soyad + " " + Environment.NewLine + secilenOgrenciDers.Ders.Kod + " " + secilenOgrenciDers.Ders.Kredi + " " + secilenOgrenciDers.Ders.Ad + Environment.NewLine + secilenOgrenciDers.Not;


        }

        private void btnOdGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenOgrenciDers != null)
                {

                    secilenOgrenciDers.OgrenciId = ((Ogrenci)(cmbOgrenciler.SelectedItem)).OgrenciBirincilAnahtar;
                    secilenOgrenciDers.DersId = ((Ders)(cmbDersler.SelectedItem)).Id;
                    secilenOgrenciDers.Not = Convert.ToInt32(cmbNotlar.Text);

                    _db.SaveChanges();
                    OgrenciDersleriGoster();
                    secilenOgrenciDers = null;
                    lblSecilenOgrenciDersi.Text = "Seçilen Öğrenci Dersi";
                    MessageBox.Show("Öğrenci dersi güncellenmiştir");
                }
                else
                    MessageBox.Show("Öğrenci dersi seçiniz");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
