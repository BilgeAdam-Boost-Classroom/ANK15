using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class Danisman
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string SoyadAd { get; set; }
        //navigation property
        public List<Ogrenci> Ogrenciler { get; set; }
    }
}
