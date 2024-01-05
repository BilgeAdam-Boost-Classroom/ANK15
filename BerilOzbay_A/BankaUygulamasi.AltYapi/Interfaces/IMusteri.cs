using BankaUygulamasi.AltYapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.AltYapi.Interfaces
{
    public interface IMusteri
    {
        public delegate int NumaraHandler(IMusteri musteri);

        public event NumaraHandler NumaratoreGit;
        public string AdSoyad { get; set; }
        public long TCNo { get; set; }
        public int Numara { get; set; }
        public MusteriTipi MusteriTipi { get; set; }
    }
}
