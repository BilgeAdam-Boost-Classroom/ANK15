using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15TRANSKRİPT.Entity
{
    public class Ogrenci:IEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
    }
    public class Donem:IEntity
    {
        public int DonemNo { get; set; }
        public string DonemAd { get; set; }
        public List<Ders> Dersler { get; set; }
    }
    public class Ders : IEntity
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        
    }
    public class DersOgrenci : IEntity
    {
        public Ogrenci Ogrenci { get; set; }
        public Donem Donemler { get; set; }
        public Ders Ders { get; set; }
        public HarfNotu HarfNotu { get; set; }
        public double Kredi
        {
            get
            {
                return (double)HarfNotu / 10;
            }
        }
    }
}
