using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15TRANSKRİPT.Entity
{
    public class Field
    {
        public static List<Ogrenci> Ogrenciler { get; set; } = new();
        public static List<Donem> Donemler { get; set; } = new();
        public static List<Ders> Dersler { get; set; } = new();
        public static List<DersOgrenci> DersOgrenciler { get; set; } = new();
    }
}
