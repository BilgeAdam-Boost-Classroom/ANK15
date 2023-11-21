using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    internal class Canli
    {
        public string Ad { get; set; }
        public string Yas { get; set; }

        public Canli(string Ad,string Yas)
        {
            this.Ad = Ad;
            this.Yas = Yas;
        }

        public virtual void SesCikar()
        {
            Console.WriteLine("Canli");
        }
    }
}
