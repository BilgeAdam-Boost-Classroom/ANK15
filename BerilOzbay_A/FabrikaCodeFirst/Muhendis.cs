using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaCodeFirst
{
    public class Muhendis
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public ICollection<MuhendisAraba> muhendisAraba { get; set; }
    }
}
