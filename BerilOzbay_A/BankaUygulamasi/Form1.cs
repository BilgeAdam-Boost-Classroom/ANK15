using BankaUygulamasi.AltYapi.Entities;
using BankaUygulamasi.AltYapi.Enums;
using BankaUygulamasi.AltYapi.Interfaces;
using System.ComponentModel;

namespace BankaUygulamasi
{
    public partial class Form1 : Form
    {
        BindingList<IMusteri> musteri = new BindingList<IMusteri>();
        TitanicBank titanicBank = new TitanicBank();
        public Form1()
        {
            InitializeComponent();
            cmbMusteriTurleri.Items.Add("Seciniz.");
            cmbMusteriTurleri.Items.Add(MusteriTipi.VIP);
            cmbMusteriTurleri.Items.Add(MusteriTipi.Gise);
            cmbMusteriTurleri.Items.Add(MusteriTipi.Bireysel);

        }


    }
}