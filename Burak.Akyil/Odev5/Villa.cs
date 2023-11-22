using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    public class Villa : IBina
    {
        public int KatSayisi { get ; set ; }
        public bool AsansorluMu { get ; set ; }
        public List<string> Odalar {  get; set ; } = new List<string>();
        public bool HavuzluMu { get; set; }

        public void Isin()
        {
            Console.WriteLine("Doğalgaz.");
        }

        public void SogukEngelle()
        {
            Console.WriteLine("Yalıtım var.");
        }
        public void BahceSula()
        {
            Console.WriteLine("Bahçe sulanıyor.");
        }
    }
}
