using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_2.Class
{
    public class Toplama
    {
        public Toplama(double sayi1,double sayi2) 
        {
            Sayi1 = sayi1;
            Sayi2 = sayi2;  
        }
        public double Sayi1 { get; init; }
        public double Sayi2 { get; init; }
        public double Topla()
        {
            return Sayi1 + Sayi2;
        }
    }
}
