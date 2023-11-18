using firinÖzellikler;
using System;

class Program
{
    static void Main()
    {
        // firin firin1 = new firin()
        // {
        //     Marka = "Siemens",
        //     Model = "ABC123",
        //     MaksimumDerece = 200,
        //     GarantiVarMi = true,
        //     GarantiSuresi = 2,
        //     Guc = "300",
        //     Fiyat=1300,

        //};
        // firin1.GarantiUzat(1);

        // Console.WriteLine("firin1 özellikleri:");
        // Console.WriteLine("Marka"+firin1.Marka);
        // Console.WriteLine("Model"+firin1.Model);
        // Console.WriteLine("Maksimum derece"+firin1.MaksimumDerece);
        // Console.WriteLine("Garanti var mı?"+firin1.GarantiVarMi);
        // Console.WriteLine("Garanti süresi:"+firin1.GarantiSuresi);
        // Console.WriteLine("Güç"+firin1.Guc);
        // Console.WriteLine("Fiyat" + firin1.Fiyat);

        // firin firin2 = new firin("Arçelik", "XYZ333", true)
        // {
        //     MaksimumDerece = 350,
        //     GarantiSuresi = 3,
        //     Guc = "G123",
        //     Fiyat = 2500,
        // };
        // firin1.GarantiUzat(2);

        // Console.WriteLine("firin2 özellikleri:");
        // Console.WriteLine("Marka" + firin2.Marka);
        // Console.WriteLine("Model" + firin2.Model);
        // Console.WriteLine("Maksimum derece" + firin2.MaksimumDerece);
        // Console.WriteLine("Garanti var mı?" + firin2.GarantiVarMi);
        // Console.WriteLine("Garanti süresi:" + firin2.GarantiSuresi);
        // Console.WriteLine("Güç" + firin2.Guc);
        // Console.WriteLine("Fiyat" + firin2.Fiyat);

        //Esya esya = new Esya();
        //esya.Fiyat = 2000;
        Musteri musteri = new Musteri();
        musteri.TC = 123456789995;
        if (musteri.TC != 0)
        {
            Console.WriteLine($"{musteri.TC} TC numarası");

        }

    }

}
