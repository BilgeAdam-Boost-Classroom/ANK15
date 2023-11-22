using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_2023
{
    internal class Insan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine($"Insan:{Familya}");
        }
        public override void TurGoster()
        {
            Console.WriteLine("Canli turu ezildi insan oldu");
        }
        public override void Yeni()
        {
            Console.WriteLine("Insan yeni");
        }
     
    }
}

