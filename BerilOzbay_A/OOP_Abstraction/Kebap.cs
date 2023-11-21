using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal class Kebap : Yemek
    {
        public override void YemekHazirla()
        {
            Console.WriteLine("Izgarada...");
        }
    }
}
