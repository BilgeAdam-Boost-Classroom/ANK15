using ANK15BankaUygulamasiAltYapisi.Enums;
using ANK15BankaUygulamasiAltYapisi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ANK15BankaUygulamasiAltYapisi.Interfaces.IMusteri;

namespace ANK15BankaUygulamasiAltYapisi.Entities
{
    public class TitanicMusteri : IMusteri
    {
        public TitanicMusteri() 
        {
            GelisSirasi = Sira;
            Sira++;

        }
        public string AdSoyad { get; set; }
        public static int Sira { get; set; } = 1;  
        public long TCNo { get; set; }
        public int Numara { get; set; }
        public int GelisSirasi { get; set; }    
        public MusteriTipi MusteriTipi { get; set; }

        public event NumaraHandler NumaratoreGit;
        public int NumaraAl()
        {
            return NumaratoreGit(this);
        }
    }
}
