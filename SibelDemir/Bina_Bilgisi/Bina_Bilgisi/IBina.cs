using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Bilgisi
{
    internal interface IBina
    {
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set; }

        public void Isın()
        {
            Console.WriteLine("merkezi sistem");
        }
        public void SogukEngelle() 
        {
            Console.WriteLine("yalıtım var.");
        }
    }
}
