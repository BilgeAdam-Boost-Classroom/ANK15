﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama_Cikarma
{
    internal class Cikarma
    {
       

        public double sayi1 { get; set; }
        public double sayi2 { get; set; }
        public Cikarma(double sayi1, double sayi2)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
        }
        public double cikar()
        {
            return this.sayi1 - this.sayi2;
        }
    }
}
