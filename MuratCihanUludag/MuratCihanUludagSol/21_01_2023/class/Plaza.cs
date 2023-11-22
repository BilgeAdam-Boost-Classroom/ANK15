using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_2023
{
    internal class Plaza : IBina
    {
        public int KatSayisi { get; set ; }
        public bool AsansorluMu { get ; set ; }
        public List<string> Ofisler { get; set ; }

        public void Isin()
        {
            Console.WriteLine("Isin");
        }

        public void SogukEngelle()
        {
            Console.WriteLine("Soguk Engellendi");
        }
        public void MesaBaslat()
        {
            Console.WriteLine("Mesai Basladi");
        }
        public void MesaBitir()
        {
            Console.WriteLine("MesaiBitir");
        }
    }

}
