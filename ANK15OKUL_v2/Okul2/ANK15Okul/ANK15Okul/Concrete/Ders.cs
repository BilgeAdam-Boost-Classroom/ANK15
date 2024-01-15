using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int Kredi { get; set; }

        //m-n için 
        public List<Ogrenci> Ogrenciler { get; set; }

        //kendi oluşturduğumuz mant to many durumu için
        public List<OgrenciDers> OgrenciDers { get; set; }
    }
}
