using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademikuygulama
{    
    public class Akademisyen
    {

        public List<string> Makaleler { get; set; }=new List<string>();

        public void  Makalegoster()
        {
            foreach (var item in Makaleler)
            {
                Console.WriteLine(item);
            }
        }
        public void MakaleEkle(string makale)
        {
            Makaleler.Add(makale);
        }
    }
}
