using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteCodeFirst
{
    public class Diploma
    {
        public int Id { get; set; }
        public string No { get; set; }
        public DateTime Tarih { get; set; }
        public Ogrenci Ogrenci { get; set; }

        public override string ToString()
        {
            return No + " " + Tarih;
        }
    }
}
