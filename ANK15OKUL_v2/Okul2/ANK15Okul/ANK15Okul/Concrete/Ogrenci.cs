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

        //1-1

        //foreign key
        public int DiplomaId { get; set; }

        //navigation property
        public Diploma Diploma { get; set; }

        //1-m
        //Foreign key
        public int DanismanId { get; set; }

        //navigation property
        public Danisman Danisman { get; set; }



        //m-n için 
        public List<Ders> Dersler { get; set; } = new List<Ders>();


        //kendi oluşturduğumuz mant to many durumu için
        public List<OgrenciDers> OgrenciDers { get; set; }

    }
}
