using System;
using System.Collections.Generic;

namespace Example_User_Add.Models;

public partial class Ogrenciler
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;
    public string AdSoyad => $"{Ad} {Soyad}";


    public string Numara { get; set; } = null!;

    public int? DanismanId { get; set; }

    public int? DiplomaId { get; set; }

    public virtual Danismanlar? Danisman { get; set; }

    public virtual Diplomalar? Diploma { get; set; }

    public virtual ICollection<OgrenciDersler> OgrenciDerslers { get; set; } = new List<OgrenciDersler>();
}
