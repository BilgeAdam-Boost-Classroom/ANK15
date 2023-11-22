using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Bilgisi
{
    internal class Villa:IBina
    {
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set; }
        public bool HavuzluMu { get; set; }

        public void Isın()
        {
            Console.WriteLine("merkezi sistem");
        }
        public void SogukEngelle()
        {
            Console.WriteLine("yalıtım yok");
        }
        private List<string> Odalar = new List<string>();
        public void BahceSula()
        {
            Console.WriteLine("Bahçe sulandı.");
        }
        public void OdaEkle(string odaadi)
        {
            Odalar.Add(odaadi);
            Console.WriteLine($"{odaadi} oda eklendi.");
        }
        public void OdalariListele()
        {
            Console.WriteLine("Odalar:");
            foreach (var oda in Odalar)
            {
                Console.WriteLine(oda);
            }
        }

    }
}
