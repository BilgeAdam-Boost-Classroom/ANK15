using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class Diploma
    {
        public int Id { get; set; }
        public string No { get; set; }
        public DateTime Tarih { get; set; }
        //Foreign key sadece tek tarafta karşı tabloda var.
        //Navigation property 
        public Ogrenci Ogrenci { get; set; }

        public override string ToString()
        {
            return No;
        }
    }
}
