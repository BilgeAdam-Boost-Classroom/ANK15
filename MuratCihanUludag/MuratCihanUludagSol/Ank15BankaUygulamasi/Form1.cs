using ANK15BankaUygulamasiAltYapisi.Entities;
using ANK15BankaUygulamasiAltYapisi.Enums;
using ANK15BankaUygulamasiAltYapisi.Interfaces;
using System.ComponentModel;

namespace Ank15BankaUygulamasi
{
    public partial class Form1 : Form
    {
        BindingList<IMusteri> musteriler;
        TitanicBank bank;
        public Form1()
        {
            InitializeComponent();
            bank = new TitanicBank();
            bank.Musteriler = new BindingList<IMusteri>();

            cmbMusteriTurleri.Items.Add("Seciniz");
            cmbMusteriTurleri.Items.Add(MusteriTipi.VIP);
            cmbMusteriTurleri.Items.Add(MusteriTipi.Bireysel);
            cmbMusteriTurleri.Items.Add(MusteriTipi.Gise);

            cmbMusteriTurleri.SelectedIndex = 0;

            bank.numarator = new TitanicNumarator();
            bank.numarator.BekleyenMusteriler = new BindingList<IMusteri>();


        }
        public void ListeyiGuncelle(BindingList<IMusteri> islemdekiMusteriler)
        {
            DvgMusteriler.DataSource = null;
            DvgMusteriler.DataSource = islemdekiMusteriler;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TitanicMusteri musteri = new TitanicMusteri();

            if (cmbMusteriTurleri.SelectedIndex == 0)
            {
                MessageBox.Show("Musteri turu seciniz");
                return;
            }

            musteri.MusteriTipi = (MusteriTipi)Enum.Parse(typeof(MusteriTipi), cmbMusteriTurleri.Text);
            musteri.TCNo = Convert.ToInt64(TxtTC.Text);
            musteri.AdSoyad = txtAdSoyad.Text;
            musteri.NumaratoreGit += bank.numarator.NumaraUret;

            bank.numarator.Musteri = musteri;
            bank.numarator.BekleyenMusteriler.Add(musteri); // islemde olan musteriler

            musteri.Numara = musteri.NumaraAl();

            bank.Musteriler.Add(musteri);//Gelen Musteri

            ListeyiGuncelle(bank.numarator.BekleyenMusteriler);

        }

        private void btnSiradaki_Click(object sender, EventArgs e)
        {
            lblSiradaki.Text = bank.numarator.SiradakiniGetir();
        }
    }
}