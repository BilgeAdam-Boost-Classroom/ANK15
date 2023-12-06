using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSistemi
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }
        public List<OgrenciDers> OgrenciDersleri { get; set; }
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
