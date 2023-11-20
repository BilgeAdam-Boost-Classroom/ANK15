using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Ogrenci : Kisi
    {
        public Ogrenci()
        {
            Dersler = new List<string>();
        }
        public string Bolum { get; set; }
        public List<string> Dersler { get; set; }

        public void DersEkle(string ders)
        {
            Dersler.Add(ders);
        }

        public void DersGoster()
        {
            foreach (var item in Dersler)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
