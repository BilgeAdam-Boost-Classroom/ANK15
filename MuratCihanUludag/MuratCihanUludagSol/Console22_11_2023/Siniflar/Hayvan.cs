using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console22_11_2023.Siniflar
{
    internal class Hayvan
    {
        public string Name { get; set; }
        public int Yas { get; set; }
        public virtual void Kosmak()
        {
            Console.WriteLine("Bu hayvan Kosuyor");
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
