using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Akademisyen : Kisi
    {
        public List<string> Makaleler { get; set; }
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
