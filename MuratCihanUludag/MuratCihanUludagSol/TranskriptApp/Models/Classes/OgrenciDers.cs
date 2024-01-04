using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;
using TranskriptApp.Models.Enum;

namespace TranskriptApp.Models.Classes
{
    public  class OgrenciDers : BaseEntity ,IOgrenciDers
    {
         public Ogrenci Ogrenci { get; set; }
         public Donem Donem { get; set; }
         public Ders Ders { get; set; }
         public HarfNot HarfNot { get; set; }
    }
}
