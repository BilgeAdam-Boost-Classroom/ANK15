namespace FirinSatıs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firin firin1 = new Firin();
            firin1.Marka = "Siemens";
            firin1.Model = "ABC123";
            firin1.MaksimumDerece = 200;
            firin1.GarantiVarMi = true;
            firin1.GarantiSuresi = 2;
            firin1.Guc = "300";
            firin1.Fiyat = 1300;
            firin1.GarantiUzat(1);

            Console.WriteLine("Fırın1 in özellikeri:");
            Console.WriteLine("Marka: " + firin1.Marka);
            Console.WriteLine("Model: " + firin1.Model);
            Console.WriteLine("MaksimumDerece: " + firin1.MaksimumDerece);
            Console.WriteLine("Garanti var mı: " + firin1.GarantiVarMi);
            Console.WriteLine("Garanti Süresi: " + firin1.GarantiSuresi);
            Console.WriteLine("Güç: " + firin1.Guc);
            Console.WriteLine("Fiyat: " + firin1.Fiyat);

            Firin firin2 = new Firin("Arçelik", "XYZ333", true);
            firin2.GarantiSuresi = 3;
            firin2.GarantiUzat(2);
            firin2.Fiyat = 2500;
            firin2.MaksimumDerece = 350;
            firin2.Guc = "400";

            Console.WriteLine("Fırın2 nin özellikeri:");
            Console.WriteLine("Marka: " + firin2.Marka);
            Console.WriteLine("Model: " + firin2.Model);
            Console.WriteLine("MaksimumDerece: " + firin2.MaksimumDerece);
            Console.WriteLine("Garanti var mı: " + firin2.GarantiVarMi);
            Console.WriteLine("Garanti Süresi: " + firin2.GarantiSuresi);
            Console.WriteLine("Güç: " + firin2.Guc);
            Console.WriteLine("Fiyat: " + firin2.Fiyat);

        }
    }
}