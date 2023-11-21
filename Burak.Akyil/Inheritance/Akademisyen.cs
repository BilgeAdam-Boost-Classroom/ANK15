using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Akademisyen : Kisi
    {
        public Akademisyen(string ad, string soyad) : base(ad, soyad)
        {

        }
        public List<string> Makaleler { get; set; } = new List<string>();
        public void MakaleGoster()
        {
            Console.WriteLine(Makaleler);
        }
        public void MakaleEkle(string makale)
        {
            Makaleler.Add(makale);
        }
    }
}
