using BankaUygulamasi.AltYapi.Enums;
using BankaUygulamasi.AltYapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.AltYapi.Entities
{
    public class TitanicMusteri : IMusteri
    {
        public string AdSoyad { get ; set ; }
        public long TCNo { get ; set ; }
        public int Numara { get ; set ; }
        public MusteriTipi MusteriTipi { get ; set ; }

        public event IMusteri.NumaraHandler NumaratoreGit;
    }
}
