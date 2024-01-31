using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public ICollection<YazarKitap> YazarKitap { get; set; }
        public ICollection<KütüphaneKitap> KütüphaneKitap { get; set; }
        public int BandrolYabancıAnahtar{ get; set; }
        public Bandrol Bandrol { get; set; }
        public int YayinEviYabanciAnahtar { get; set; }
        public YayınEvi YayınEvi { get; set; }
    }
}
