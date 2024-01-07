using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaCodeFirst
{
    public class Plaka
    {
        public int Id { get; set; }
        public string Kodu { get; set; }
        public Araba Araba { get; set; }
        public override string ToString()
        {
            return Kodu;
        }
    }
}
