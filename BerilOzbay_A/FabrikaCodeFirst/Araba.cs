using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaCodeFirst
{
    public class Araba
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Yıl { get; set; }
        //Foreign Key
        public int PlakaId { get; set; }
        //Navigation Property
        public Plaka Plaka { get; set; }

        public int KisiId { get; set; }
        public Kisi Kisi { get; set; }
        public ICollection<MuhendisAraba> muhendisAraba { get; set; }
    }
}
