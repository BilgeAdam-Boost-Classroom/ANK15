using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Kedi : Hayvan
    {
        public string Cinsi { get; set; }
        public void Kos()
        {
            Console.WriteLine("Kedi koşuyor...");
        }
        public void Mirlama()
        {
            Console.WriteLine("Miyav...");
        }
    }
}
