using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Kebap : Yemek
    {
        public override void YemekHazirlan()
        {
            Console.WriteLine("Izgarada...");
        }

        public override void Sunul()
        {
            Console.WriteLine("Dürümde...");
        }
    }
}
