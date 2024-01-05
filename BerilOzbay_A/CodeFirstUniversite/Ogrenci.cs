using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Numara { get; set; }

        //Foreign Key -> Diploma sınıfının ID'si ile eşlenir.
        public int DiplomaId { get; set; }
        //Navigation property
        public Diploma Diploma { get; set; }

        //Foreign Key -> Danisman sinifinin ID'si ile eslenir.
        public int DanismanId { get; set; }
        //Navigation property
        public Danisman Danisman { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; }

        public override string ToString()
        {
            return Adı + " " + Soyadı;
        }
    }
}
