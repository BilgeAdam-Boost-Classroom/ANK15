using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Concrete
{
    public class OgrenciDers
    {

        //Primary key
        public int Id { get; set; }

        //öğrenci için foreign key
        public int OgrenciId { get; set; }

        //navigation prop.
        public Ogrenci Ogrenci { get; set; }

        //ders için foreign key
        public int DersId { get; set; }

        //navigation prop.
        public Ders Ders { get; set; }

        public int Not { get; set; }


    }
}
