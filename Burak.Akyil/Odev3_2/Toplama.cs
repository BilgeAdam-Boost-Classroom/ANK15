using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_2
{
    internal class Toplama
    {
        public double Sayi1 { get; set; }
        public double Sayi2 { get; set; }
        public Toplama(double x, double y)
        {
            Sayi1 = x;  Sayi2 = y;
        }
        public double Topla()
        {
            return Sayi1 + Sayi2;
        }
    }
}
            
            
