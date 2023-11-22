using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_2023
{
    internal interface IBina
    {
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set; }
        public void Isin();
        public void SogukEngelle();
        public void F()
        {
            Console.WriteLine("f metotu");
        }
    }
}
