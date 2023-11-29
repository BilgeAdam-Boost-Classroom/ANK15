using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.AltYapi
{
    public interface INumaratör
    {
        public IMusteri Musteri { get; set; }
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }
        public int VIPSayac { get; set; }
        public int GiseSayac { get; set; }
        public int BireyselSayac { get; set; }
        public string SiradakiniGetir();
        //kişinin numarasını döndürsün

        public int NumaraUret();

    }
}
