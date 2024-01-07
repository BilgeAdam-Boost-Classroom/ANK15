using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabamDb_codeFirst
{
    public class Plaka
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int ArabaId { get; set; }
        //navigation property
        public Araba Araba { get; set; }
    }
}
