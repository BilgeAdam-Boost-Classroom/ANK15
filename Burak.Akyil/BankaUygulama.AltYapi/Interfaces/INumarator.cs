using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulama.AltYapi.Interfaces
{
    public interface INumarator
    {
        public IMusteri Musteri { get; set; }
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }
        public int VIPSayac { get; set; }
        public int GiseSayac { get; set; }
        public int BireyselSayac { get; set; }
        public string SiradakiniGetir();
        public int NumaraUret(IMusteri musteri);
        
        
    }
}
