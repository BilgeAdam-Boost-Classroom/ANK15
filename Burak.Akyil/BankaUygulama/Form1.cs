using BankaUygulama.AltYapi.Entities;
using BankaUygulama.AltYapi.Enums;
using BankaUygulama.AltYapi.Interfaces;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace BankaUygulama
{
    public partial class Form1 : Form
    {
        TitanicBank banka = new TitanicBank();
        public Form1()
        {
            InitializeComponent();
            cmbMusteriTurleri.Items.Add("SEÇÝNÝZ");
            cmbMusteriTurleri.Items.Add(MusteriTipi.Bireysel);
            cmbMusteriTurleri.Items.Add(MusteriTipi.Gise);
            cmbMusteriTurleri.Items.Add(MusteriTipi.VIP);

            cmbMusteriTurleri.SelectedIndex = 0;

            banka.Musteriler = new BindingList<IMusteri>();
            banka.Numarator = new TitanicNumarator();
            banka.Numarator.BekleyenMusteriler = new BindingList<IMusteri>();
        }
        public void ListeyiGuncelle(BindingList<IMusteri> islemdekiMusteriler)
        {
            dgvMusteriler.DataSource = null;
            dgvMusteriler.DataSource = islemdekiMusteriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TitanicMusteri gelenMusteri = new TitanicMusteri();
            if (cmbMusteriTurleri.SelectedIndex == 0)
            {
                MessageBox.Show("Müþteri türünü seçiniz!");
                return;
            }
            gelenMusteri.MusteriTipi = (MusteriTipi)Enum.Parse(typeof(MusteriTipi), cmbMusteriTurleri.Text);
            gelenMusteri.AdSoyad = txtAdSoyad.Text;
            gelenMusteri.TCNo = Convert.ToInt64(txtTcNo.Text);
            gelenMusteri.NumaratoreGit += banka.Numarator.NumaraUret;

            banka.Numarator.Musteri = gelenMusteri;
            banka.Numarator.BekleyenMusteriler.Add(gelenMusteri);
            gelenMusteri.Numara = gelenMusteri.NumaraAl();
            banka.Musteriler.Add(gelenMusteri);
            ListeyiGuncelle(banka.Numarator.BekleyenMusteriler);


        }

        private void btnSiradaki_Click(object sender, EventArgs e)
        {
            lblSiradaki.Text = banka.Numarator.SiradakiniGetir();
        }
    }
}