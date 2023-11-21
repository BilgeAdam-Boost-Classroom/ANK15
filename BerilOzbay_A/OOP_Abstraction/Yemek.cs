using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal abstract class Yemek
    {
        public bool DiyetMi {  get; set; }
        public double SosMiktari { get; set; }
        public abstract void YemekHazirla();
        public void Sunus()
        {
            Console.WriteLine("Yemek Servis ediliyor...");
        }

    }
}
