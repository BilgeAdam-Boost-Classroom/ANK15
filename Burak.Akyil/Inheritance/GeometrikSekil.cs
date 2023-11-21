using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public GeometrikSekil()
        {
            Console.WriteLine("Geometrik şekil oluşturuldu.");
        }
       public double CevreHesapla()
        {
            return 2 * (Genislik + Yukseklik);
        }
       public double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
}
