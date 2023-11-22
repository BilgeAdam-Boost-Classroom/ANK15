using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_2023
{
    internal abstract class Tur
    {

        public string Familya { get; set; }
        public string Aile { get; set; }
        public string CanliTuru { get; set; }
        public virtual void TurGoster()
        {
            Console.WriteLine("CanliTuru");
        }
        public void TurGoster(bool isBase)
        {
            Console.WriteLine("CanliTuru");
        }
        public void AileGoster()
        {
            Console.WriteLine($"Aile:{Aile}");
        }
        public abstract void FamilyaGoster();
        public virtual void Yeni()
        {
            Console.WriteLine("tur yeni");
        }


    }
}

