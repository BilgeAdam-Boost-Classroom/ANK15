using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_2023
{
    internal class Villa : IBina
    {
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set; }
        public List<string> Odalar { get; set; }

        public bool HavuzluMu(bool havuzluMu)
        {
            return havuzluMu;
        }

        public void BahceSula()
        {
            Console.WriteLine("Bahce Sulandi");
        }

        public void Isin()
        {
            Console.WriteLine("Isin Villa");
        }

        public void SogukEngelle()
        {
            Console.WriteLine("Soguk Engellendi villa");

        }
    }

}

