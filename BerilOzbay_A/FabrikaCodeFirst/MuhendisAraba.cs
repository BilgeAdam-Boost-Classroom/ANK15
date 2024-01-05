using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaCodeFirst
{
    public class MuhendisAraba
    {
        public int Id { get; set; }
        public Araba Araba { get; set; }
        public int ArabaId { get; set; }
        public Muhendis Muhendis { get; set; }
        public int MuhendisId { get; set; }
    }
}
