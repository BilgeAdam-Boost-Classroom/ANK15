using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Yemek
    {
        public Yemek()
        {
            Console.WriteLine("Yemek yapıcısı");
        }
        public bool DiyetMi { get; set; }
        public double SosMiktari { get; set; }

        public abstract void YemekHazirlan();

        public virtual void Sunul()
        {
            Console.WriteLine("Servis ediliyor...");
        }
    }
}
