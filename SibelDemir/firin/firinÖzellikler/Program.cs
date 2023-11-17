using firinÖzellikler;
using System;

class Program
{
    static void Main()
    {
        firin firin1 = new firin()
        {
            Marka = "siemens",
            Model = "ABC123",
            MaksimumDerece = 200,
            GarantiVarMi = true,
            GarantiSuresi = 2,
            Guc = "300",
            Fiyat=1300,

       };
        firin1.GarantiUzat(1);

        Console.WriteLine("firin1 özellikleri:");
        Console.WriteLine("marka"+firin1.Marka);
        Console.WriteLine("model"+firin1.Model);
        Console.WriteLine("maksimum derece"+firin1.MaksimumDerece);
        Console.WriteLine("garanti var mı?"+firin1.GarantiVarMi);
        Console.WriteLine("garanti süresi:"+firin1.GarantiSuresi);
        Console.WriteLine("güç"+firin1.Guc);
        Console.WriteLine("fiyat" + firin1.Fiyat);

        firin firin2 = new firin("Arçelik", "XYZ333", true)
        {
            MaksimumDerece = 350,
            GarantiSuresi = 3,
            Guc = "G123",
            Fiyat = 2500,
        };
        firin1.GarantiUzat(2);

        Console.WriteLine("firin2 özellikleri:");
        Console.WriteLine("marka" + firin2.Marka);
        Console.WriteLine("model" + firin2.Model);
        Console.WriteLine("maksimum derece" + firin2.MaksimumDerece);
        Console.WriteLine("garanti var mı?" + firin2.GarantiVarMi);
        Console.WriteLine("garanti süresi:" + firin2.GarantiSuresi);
        Console.WriteLine("güç" + firin2.Guc);
        Console.WriteLine("fiyat" + firin2.Fiyat);

    }

}
