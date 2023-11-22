using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Siniflar
{
    internal class Kedi : Hayvan
    {
        public string Cinsi { get; set; }
        public void Mirlama()
        {
            Console.WriteLine("Miyav");
        }
        public override void Kos()
        {
            Console.WriteLine("Kedi kosuyor.");
        }
    }
}
