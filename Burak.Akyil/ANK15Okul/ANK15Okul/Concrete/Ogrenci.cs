using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public int DiplomaId { get; set; }
        public Diploma Diploma { get; set; }
        public int DanismanId { get; set; }
        public Danisman Danisman { get; set; } 
        public List<Ders> Dersler { get; set; } = new List<Ders>();
        public List<OgrenciDers> OgrenciDers { get; set; }
    }
}
