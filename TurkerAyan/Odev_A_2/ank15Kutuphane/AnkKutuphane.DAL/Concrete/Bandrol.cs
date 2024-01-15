using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkKutuphane.DAL.Concrete
{
    public class Bandrol
    {
        public int Id { get; set; }
        public int No { get; set; }
        public kitap kitap { get; set; }
    }
}
