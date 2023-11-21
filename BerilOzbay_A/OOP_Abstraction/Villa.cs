using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal class Villa : IBina
    {
        public List<string> Odalar { get; set; }
        public Villa()
        {
            Odalar = new List<string>();
        }
        public bool HavuzluMu { get; set; }
        public int KatSayisi { get ; set ; }
        public bool AsansorluMu { get ; set ; }

        public void Isin()
        {
            Console.WriteLine("Yerden isitmali");
        }

        public void SogukEngelle()
        {
            Console.WriteLine("Mantolama ve pimapen"); ;
        }

        public void BahceSula()
        {

            Console.WriteLine("Bahce Sulaniyor.");
        }
    }
}
