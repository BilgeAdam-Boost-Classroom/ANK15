using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunButton
{
    internal class Oyun
    {
        private int _toplam;
        public int Sayi1 { get; set; } = -5;
        public int Sayi2 { get; set; } =-5;
        public Durum Durum { get; set; }
        public int Toplam()
        {
            return Sayi1 + Sayi2;

        }
    }
}
