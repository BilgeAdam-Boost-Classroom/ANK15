using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    public class Plaza : IBina
    {
        public int KatSayisi { get ; set ; }
        public bool AsansorluMu { get ; set ; }
        public List<string> Ofisler { get ; set ; } = new List<string>();  
        public void Isin()
        {
            Console.WriteLine("Merkezi ısıtmalı.");
        }

        public void SogukEngelle()
        {
            Console.WriteLine("Yalıtım yok.");
        }
        public void MesaiBaslat()
        {
            Console.WriteLine("Mesai başladı.");
        }
        public void MesaiBitir()
        {
            Console.WriteLine("Mesai bitti.");
        }

        
    }
}
