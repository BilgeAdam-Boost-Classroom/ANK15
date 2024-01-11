using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class KütüphaneKitap
    {
        public int Id { get; set; }
        public int KitapYabanciAnahtar { get; set; }
        public Kitap Kitap { get; set; }

        public int KütüphaneYabanciAnahtar { get; set; }
        public Kütüphane Kütüphane { get; set; }
    }
}
