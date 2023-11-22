using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriUygulama
{
    public class GeometriSekil
    {
        public GeometriSekil()
        {
            Console.WriteLine("Geometrik Şekil oluşturuldu");
        }

        public double Genislik { get; set; }
        public double Yukseklik { get; set; }


        public double CevreHesapla()
        {
            return 2 * (Genislik * Yukseklik);

        }
        public double AlanHesapla()
        {
            return (Genislik * Yukseklik);
        }
    }
}
