using ANK15BankaUygulamasiAltYapisi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANK15BankaUygulamasiAltYapisi.Enums;

namespace ANK15BankaUygulamasiAltYapisi.Entities
{
    public class TitanicNumarator : INumarator
    {
        public TitanicNumarator()
        {
            VIPSayac = 1000;
            BireyselSayac = 3000;
            GiseSayac = 5000;

        }



        //Numaratore gelen o anki musteri
        public IMusteri Musteri { get; set; }
        //Islem icin sayi bekleyenler
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }
        public int VIPSayac { get; set; }
        public int GiseSayac { get; set; }
        public int BireyselSayac { get; set; }



        public int NumaraUret(IMusteri musteri)
        {
            // Eger Vip iseSayacindan 
            //Gise ise gisesayacindan
            //Bireysel ise bireysel sayacindan dondur

            return Musteri.MusteriTipi == MusteriTipi.VIP ? VIPSayac++ :
                Musteri.MusteriTipi == MusteriTipi.Bireysel ? BireyselSayac++ : GiseSayac++;
        }

        public string SiradakiniGetir()
        {
            //List<IMusteri> siralanacakMusteriler = new List<IMusteri>(); 

            List<IMusteri> vipListe = BekleyenMusteriler.Where(m => m.MusteriTipi == MusteriTipi.VIP).OrderBy(m => m.Numara).ToList();
            List<IMusteri> digerleri = BekleyenMusteriler.Where(m => m.MusteriTipi != MusteriTipi.VIP).ToList();

            StringBuilder sb = new StringBuilder();

            if (BekleyenMusteriler != null)
            {
                //siralanacakMusteriler = BekleyenMusteriler.OrderBy(m => m.MusteriTipi).ThenBy(m => m.GelisSirasi).ToList();
                //Ilk Once Vip olanlari bir listeye alicaz.Bu Vip leri de numaralarina gore siralayalim.
                //Sonra da digerlerini bir listeye alalim.
                //Bu listelere gorede getirecez.
                if (vipListe.Count > 0)
                {
                    IMusteri musteri = vipListe[0];
                    sb.Append($"Turu: {musteri.AdSoyad} {musteri.TCNo} {musteri.Numara}");

                    BekleyenMusteriler.Remove(musteri);

                }
                else if (digerleri.Count > 0)
                {
                    IMusteri musteri = digerleri[0];
                    sb.Append($"Turu: {musteri.AdSoyad} {musteri.TCNo} {musteri.Numara}");

                    BekleyenMusteriler.Remove(musteri);
                }
                else
                {
                    sb.Append("Bekleyen Musteri Yoktur");
                }

            }

            return sb.ToString();
        }
    }
}
