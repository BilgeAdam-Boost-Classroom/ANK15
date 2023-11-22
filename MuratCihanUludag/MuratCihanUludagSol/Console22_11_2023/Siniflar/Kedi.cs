using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console22_11_2023.Siniflar
{
    internal class Kedi : Hayvan
    {
        public string Cinsi { get; set; }
        public override void Kosmak()
        {
            Console.WriteLine("Kedi kosuyor");
        }
        public  void Mirlamak()
        {

        }
    }
}
