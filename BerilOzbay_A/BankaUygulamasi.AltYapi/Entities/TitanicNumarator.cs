using BankaUygulamasi.AltYapi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaUygulamasi.AltYapi.Enums;

namespace BankaUygulamasi.AltYapi.Entities
{
    public class TitanicNumarator : INumarator
    {
        public TitanicNumarator()
        {
            VIPSayac = 1000;
            BireyselSayac = 3000;
            GiseSayac = 5000;
        }
        public IMusteri Musteri { get; set; }
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }
        public int VIPSayac { get; set; }
        public int GiseSayac { get; set; }
        public int BireyselSayac { get; set; }
        public int NumaraUret(IMusteri musteri)
        {
            return Musteri.MusteriTipi == MusteriTipi.VIP ? VIPSayac++ :
                Musteri.MusteriTipi == MusteriTipi.Bireysel ? BireyselSayac++ : GiseSayac++;
        }
        public string SiradakiniGetir()
        {
            //List<IMusteri> siralanacakMusteriler = new List<IMusteri>();
            List<IMusteri> vipListe = BekleyenMusteriler.Where(m => m.MusteriTipi == MusteriTipi.VIP).OrderBy(m => m.Numara).ToList();
            List<IMusteri> digerleri = BekleyenMusteriler.Where(m => m.MusteriTipi != MusteriTipi.VIP).ToList();
            StringBuilder sonuc = new StringBuilder();
            if (BekleyenMusteriler != null)
            {
                if (vipListe.Count > 0)
                {
                    sonuc.Append("Türü" + vipListe[0].AdSoyad + " " + vipListe[0].TCNo + " " + vipListe[0].Numara);
                    BekleyenMusteriler.Remove(vipListe[0]);
                }
                //siralanacakMusteriler = BekleyenMusteriler.OrderBy(m => m.MusteriTipi).ThenBy(m => m.GelisSirasi).ToList();
                else if (digerleri.Count > 0)
                {
                    sonuc.Append("Türü" + digerleri[0].AdSoyad + " " + digerleri[0].TCNo + " " + digerleri[0].Numara);
                    BekleyenMusteriler.Remove(digerleri[0]);
                }
                else
                {
                    sonuc.Append("Bekleyen musteri yoktur.");
                }
            }
            return sonuc.ToString();
        }
    }
}
