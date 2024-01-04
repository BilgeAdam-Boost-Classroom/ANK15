using ANK15BankaUygulamasiAltYapisi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15BankaUygulamasiAltYapisi.Interfaces
{
    public interface IMusteri
    {
        //IMusteri turunde tum metotolari temsil eder
        public delegate int NumaraHandler(IMusteri musteri);

        public event NumaraHandler NumaratoreGit;

        //Musteri adi soy adi olmali
        public string AdSoyad { get; set; }
        // Musterinin tc kimlik no su olmali
        public long TCNo {  get; set; }   
        //Musteri numaratorden numara alacak bu o numara
        public int Numara { get; set; } 
        //musteri tipi olmali enum olucak bu
        public int GelisSirasi { get; set; }    
        public MusteriTipi MusteriTipi { get; set; }

    }
}
