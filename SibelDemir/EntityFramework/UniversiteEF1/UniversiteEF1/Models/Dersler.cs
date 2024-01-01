using System;
using System.Collections.Generic;

namespace UniversiteEF1.Models;

public partial class Dersler
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public int Kredi { get; set; }

    public virtual ICollection<OgrenciDersler> OgrenciDerslers { get; set; } = new List<OgrenciDersler>();
    public override string ToString()
    {
        return Ad;
    }
}
