using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Danisman
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        //Navigation property
        public ICollection<Ogrenci> Ogrenciler { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
