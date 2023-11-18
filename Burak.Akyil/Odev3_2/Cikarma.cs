using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_2
{
    internal class Cikarma
    {
        public double Sayi1 { get; set; }
        public double Sayi2 { get; set; }
        public Cikarma(double x, double y)
        {
            Sayi1 = x; Sayi2 = y;
        }
        public double Cikar()
        {
            return Sayi1 - Sayi2;
        }
    }
}
