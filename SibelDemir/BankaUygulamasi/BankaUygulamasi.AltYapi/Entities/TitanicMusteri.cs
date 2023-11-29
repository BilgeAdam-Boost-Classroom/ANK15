using BankaUygulamasi.AltYapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.AltYapi.Entities
{
    public class TitanicMusteri : IMusteri
    {
        public TitanicMusteri()
        {
            GelisSirasi = sira;
            sira++;
        }
        public static int sira { get; set; } = 1;
        public string AdSoyad { get; set; }
        public long TCNo { get; set; }
        public int Numara { get; set ; }
        public MusteriTipi MusteriTipi { get ; set ; }
        public int GelisSirasi { get; set; }
       

    }
}
