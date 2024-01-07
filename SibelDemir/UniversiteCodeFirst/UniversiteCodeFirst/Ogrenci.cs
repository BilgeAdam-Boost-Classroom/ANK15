using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteCodeFirst
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        //foreign key
        public int DiplomaId { get; set; }
        //navigation property
        public Diploma Diploma { get; set; }

        //foreign key
        public int DanismanId { get; set; }
        public Danisman Danisman { get; set; }
        public List <Ders> Dersler { get; set; }
        public List<OgrenciDers>OgrenciDers { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad + " " + Numara;
        }

    }
}
