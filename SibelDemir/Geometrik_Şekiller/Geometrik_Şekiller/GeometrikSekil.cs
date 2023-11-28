using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrik_Şekiller
{
    internal class GeometrikSekil
    {
        public GeometrikSekil()
        {
            Console.WriteLine("Ekrana Geometrik Şekil Oluşturuldu");
        }

        public double Yükseklik { get; set; }
        public double Genislik { get; set; }

        public double CevreHesapla()
        {
            return 2 * (Genislik + Yükseklik);
        }

        public double AlanHesapla()
        {
            return Genislik * Yükseklik;
        }
    }
}
