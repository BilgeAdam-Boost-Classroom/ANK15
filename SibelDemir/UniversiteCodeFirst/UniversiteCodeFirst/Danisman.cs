using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteCodeFirst
{
    public class Danisman
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Ogrenci>Ogrenciler { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }

}
