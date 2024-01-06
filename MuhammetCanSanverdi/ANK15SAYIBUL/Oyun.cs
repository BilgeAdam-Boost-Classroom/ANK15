using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15SAYIBUL
{
    public class Oyun
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        public Durum Durum { get; set; }
        public int Toplam { get { return Sayi1 + Sayi2; } }

    }
    public enum Durum
    {
        Kazandı,
        Kaybetti
    }
}
