using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Sube
    {
        public int SubeBirincilAnahtar { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
