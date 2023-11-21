using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal class Plaza : IBina
    {
        public List<string> Ofisler { get; set; }
        public Plaza()
        {
            Ofisler = new List<string>();
        }
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set ; }

        public void Isin()
        {
            Console.WriteLine("Dogalgaz");
        }

        public void SogukEngelle()
        {
            Console.WriteLine("Mantolama Sistemi");
        }

        public void MesaiBaslat() 
        {
            Console.WriteLine("Mesai Basladi.");
        }

        public void MesaiBitir()
        {
            Console.WriteLine("Mesai Bitti.");
        }

    }
}
