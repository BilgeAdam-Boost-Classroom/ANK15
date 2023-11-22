using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Bilgisi
{
    internal class Plaza:IBina

    {
        public int KatSayisi { get; set; }
        public bool AsansorluMu { get; set; }
        
        private List<string> Ofisler = new List<string>();

        public void MesaiBaslat()
        {
            Console.WriteLine("Mesai başladı!");
        }
        public void MesaiBitir()
        {
            Console.WriteLine("Mesai bitti!");
        }
        public void OfisEkle(string ofisAdi)
        {
            Ofisler.Add(ofisAdi);
            Console.WriteLine($"{ofisAdi} ofisi eklendi.");
        }
        public void OfisleriListele()
        {
            Console.WriteLine("Ofisler:");
            foreach (var ofis in Ofisler)
            {
                Console.WriteLine(ofis);
            }
        }

        public void Isın()
        {
            Console.WriteLine("merkezi sistem");
        }
        public void SogukEngelle()
        {
            Console.WriteLine("yalıtım var");
        }
    }
   
}
