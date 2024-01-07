using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabamDb_codeFirst
{
    public class Muhendis
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public List<Araba> Arabalar { get; set; }
        public List<MuhendisAraba> MuhendisArabalar { get; set; }

    }
}
