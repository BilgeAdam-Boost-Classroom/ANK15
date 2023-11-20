using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class GeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public GeometrikSekil()
        {
            Console.WriteLine("Geometrik Sekil olusturuldu.");
        }

        public double CevreHesapla()
        {
            return (Genislik + Yukseklik) * 2;
        }

        public double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
}
