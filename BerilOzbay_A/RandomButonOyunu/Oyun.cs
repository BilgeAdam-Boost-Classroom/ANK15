using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomButonOyunu
{
    public class Oyun
    {
        public int Sayi1 { get;  }
        public int Sayi2 { get;  }
        public KazanmaDurumu kazanmaDurumu { get; set; }
        public int Toplam { get; }
    }
}
