using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabamDb_codeFirst
{
    public class Araba
    {
        public int Id { get; set; }
        public string model { get; set; }
        public int yil { get; set; }
        public int PlakaId { get; set; }
        //navigation property
        public Plaka Plaka { get; set; }

        public int SahipId { get; set; }
        public Sahip Sahip { get; set; }

        public List<Muhendis> Muhandisler { get; set; }
        public List<MuhendisAraba> MuhendisArabalar { get; set; }

    }
}
