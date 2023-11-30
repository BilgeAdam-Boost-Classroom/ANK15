using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaUygulama.AltYapi.Enums;
using BankaUygulama.AltYapi.Interfaces;
using static BankaUygulama.AltYapi.Interfaces.IMusteri;

namespace BankaUygulama.AltYapi.Entities
{
    public class TitanicMusteri : IMusteri
    {
        public TitanicMusteri()
        {
            GelisSirasi = Sira;
            Sira++;
        }
        public static int Sira { get; set; } = 0;
        public string AdSoyad { get; set; }

        public long TCNo { get; set; }

        public int Numara { get; set; }

        public MusteriTipi MusteriTipi { get; set; }
        public int GelisSirasi { get; set; }

        public event NumaraHandler NumaratoreGit;

        public int NumaraAl()
        {
            return NumaratoreGit(this);
        }
    }
}
