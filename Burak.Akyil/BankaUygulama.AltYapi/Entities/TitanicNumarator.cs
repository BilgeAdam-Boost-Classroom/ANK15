using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaUygulama.AltYapi.Enums;
using BankaUygulama.AltYapi.Interfaces;

namespace BankaUygulama.AltYapi.Entities
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
        
        public string SiradakiniGetir()
        {
            List<IMusteri> vipListe = BekleyenMusteriler.Where(m => m.MusteriTipi == MusteriTipi.VIP).ToList();
            List<IMusteri> digerleri = BekleyenMusteriler.Where(m => m.MusteriTipi != MusteriTipi.VIP).ToList();
            StringBuilder sonuc = new StringBuilder();
            if(BekleyenMusteriler != null)
            {
                if (vipListe.Count > 0)
                {
                    var siradaki = vipListe[0];
                    sonuc.Append("Türü: " + siradaki.AdSoyad + " " + siradaki.TCNo + " " + siradaki.Numara);
                    BekleyenMusteriler.Remove(siradaki);
                }
                else if (digerleri.Count > 0)
                {
                    var siradaki = digerleri[0];
                    sonuc.Append("Türü: " + siradaki.AdSoyad + " " + siradaki.TCNo + " " + siradaki.Numara);
                    BekleyenMusteriler.Remove(siradaki);
                }
                else
                    sonuc.Append("Sırada bekleyen müşteri yoktur.");
                
            }
            return sonuc.ToString();
        }
        public int NumaraUret(IMusteri musteri)
        {
            return Musteri.MusteriTipi == MusteriTipi.VIP ? VIPSayac++ : Musteri.MusteriTipi == MusteriTipi.Bireysel ? BireyselSayac++ : GiseSayac++;
        }
            
        
    }
}
