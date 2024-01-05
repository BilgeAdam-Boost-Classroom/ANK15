using System;
using System.Collections.Generic;

namespace UniversiteDBFirst.Models
{
    public partial class Dersler
    {
        public Dersler()
        {
            OgrenciDerslers = new HashSet<OgrenciDersler>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public int Kredi { get; set; }

        public virtual ICollection<OgrenciDersler> OgrenciDerslers { get; set; }
    }
}
