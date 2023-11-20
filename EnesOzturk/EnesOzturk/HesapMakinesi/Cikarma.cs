using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    public class Cikarma
    {
        public Cikarma(double _sayi1, double _sayi2)
        {
            Sayi1 = _sayi1;
            Sayi2 = _sayi2;
        }
        public double Sayi1 { get; set; }
        public double Sayi2 { get; set; }

        public double Cikar()
        {
            return Sayi1-Sayi2;

        }
    }
}
