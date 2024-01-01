using System;
using System.Collections.Generic;

namespace UniversiteEF1.Models;

public partial class Danismanlar
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public virtual ICollection<Ogrenciler> Ogrencilers { get; set; } = new List<Ogrenciler>();

    public override string ToString()
    {
        return Ad+ " "+Soyad;
    }
}
