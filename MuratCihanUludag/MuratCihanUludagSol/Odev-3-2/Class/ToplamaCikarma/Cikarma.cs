using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_2.Class
{
    internal class Cikarma
    {
        internal Cikarma(double sayi1 ,double sayi2) 
        {
            Sayi1 = sayi1;
            Sayi2 = sayi2;
        }
        public double Sayi1 { get; set; }
        public double Sayi2 { get; set; }
        internal double Cikar()
        {
            return Sayi1 - Sayi2;   
        }
    }
   
}
