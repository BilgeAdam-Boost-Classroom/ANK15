using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Ders
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Kodu { get; set; }
        public int Kredi { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; }

        public override string ToString()
        {
            return Kodu + " " + Kredi;
        }

    }
}
