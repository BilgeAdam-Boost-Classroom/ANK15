using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikSekil.Geometri
{
    internal class Geometrik
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public double CevreHesap()
        {
            return 2 * (Genislik + Yukseklik);
        }
        public double AlanHesabi()
        {
            return Genislik * Yukseklik;
        }
    }
}
