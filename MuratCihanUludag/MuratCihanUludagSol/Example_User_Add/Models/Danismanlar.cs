using System;
using System.Collections.Generic;

namespace Example_User_Add.Models;

public partial class Danismanlar
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;
    public string AdSoyad => $"{Ad} {Soyad}";

    public virtual ICollection<Ogrenciler> Ogrencilers { get; set; } = new List<Ogrenciler>();
}
