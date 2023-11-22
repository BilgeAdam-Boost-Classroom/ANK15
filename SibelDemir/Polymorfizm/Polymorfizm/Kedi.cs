using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm
{
    public class Kedi:Hayvan
    {
        public string Cinsi { get; set; }
        public  void Kos()
        {
           
            Console.WriteLine("kedi koşuyor");
        }
        public void Mirlama()
        {
            Console.WriteLine("Miyav...");
        }
    }
}
