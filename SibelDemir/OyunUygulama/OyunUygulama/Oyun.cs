using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunUygulama
{
    public class Oyun
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        public Durum Durum { get; set; }

        public int _toplam;
        public int Toplam
        {
            get { return _toplam; }
           private set { _toplam = Sayi1+Sayi2; }
        }
        
    }
}
