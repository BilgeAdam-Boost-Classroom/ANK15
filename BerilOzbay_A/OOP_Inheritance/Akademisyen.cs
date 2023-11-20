using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Akademisyen : Kisi
    {
        public List<string> Makaleler { get; set; }

        public Akademisyen()
        {
            Makaleler = new List<string>();
        }

        public void MakaleGoster()
        {
            foreach (var item in Makaleler)
            {
                Console.WriteLine(item + " ");
            }
        }

        public void MakaleEkle(string makale)
        {
            Makaleler.Add(makale);
        }
    }
}
