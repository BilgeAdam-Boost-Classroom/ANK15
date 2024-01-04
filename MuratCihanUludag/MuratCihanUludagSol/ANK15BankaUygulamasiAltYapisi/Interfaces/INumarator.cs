using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15BankaUygulamasiAltYapisi.Interfaces
{
    public interface INumarator
    {
        //Tek Musteri oldugunda musterisini belirttik.
        public IMusteri Musteri { get; set; }
        //Kuyrukta bekleyen Musteri bunlar
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }   
        public int VIPSayac {  get; set; }
        public int GiseSayac {  get; set; } 
        public int BireyselSayac { get; set; }
        public string SiradakiniGetir(); // Kisinin numurasinini dondursun.
        public int NumaraUret(IMusteri musteri); // Bu Numara Uretecek bize
    }
}
