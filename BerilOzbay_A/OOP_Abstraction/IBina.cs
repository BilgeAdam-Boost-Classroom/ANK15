using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal interface IBina
    {
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set; }
        public void Isin();
        public void SogukEngelle();

        

    }
}
