 using BankaUygulamasi.AltYapi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.AltYapi.Entities
{
    public class TitanicNumarator : INumaratör
    {
        public TitanicNumarator()
        {
            VIPSayac = 1000;
            BireyselSayac = 3000;
            GiseSayac = 5000;
            
        }
        
        public IMusteri Musteri { get ; set; }
        public BindingList<IMusteri> BekleyenMusteriler { get ; set; }
        public int VIPSayac { get; set ; }
        public int GiseSayac { get ; set; }
        public int BireyselSayac { get ; set; }
        public int NumaraUret()
        {
            return Musteri.MusteriTipi == MusteriTipi.VIP ? VIPSayac++ :
                Musteri.MusteriTipi == MusteriTipi.Bireysel ? BireyselSayac++ : GiseSayac++;
        }
        public string SiradakiniGetir()
        {
            List<IMusteri> vipListe = BekleyenMusteriler.Where(m => m.MusteriTipi == MusteriTipi.VIP).OrderBy(m => m.Numara).ToList();
            List<IMusteri> digerleri = BekleyenMusteriler.Where(m => m.MusteriTipi != MusteriTipi.VIP).ToList();
            if (BekleyenMusteriler != null)
            {
               //siralanacakMusteriler=BekleyenMusteriler.OrderBy(m=>m.MusteriTipi).ThenBy (m=>m.GelisSirasi).ToList(); 
            }
        }

        
    }
}
