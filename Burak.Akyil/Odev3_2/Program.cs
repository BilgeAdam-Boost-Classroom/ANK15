namespace Odev3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama toplama = new Toplama(5, 3);
            double toplamaSonucu = toplama.Topla();
            Console.WriteLine("Toplama Sonucu: " + toplamaSonucu);
            Cikarma cikarma = new Cikarma(5, 3);
            double cikarmaSonucu = cikarma.Cikar();
            Console.WriteLine("Çıkarma sonucu: " + cikarmaSonucu);

            Console.WriteLine("----------------------");

            Calisan calisan1 = new Calisan("Burak", "Akyil", "IT", "B324", new DateTime(2022, 5, 6));
            Console.WriteLine("Çalışan Burak: " + calisan1.Ad + " " + calisan1.Soyad + " " + calisan1.Birim + " " + calisan1.SicilNo + " " + calisan1.GoreveBaslamaTarihi);
            Calisan calisan2 = new Calisan("Janset", "Dereli", "HR", "C231", new DateTime(2022, 4, 2));
            Console.WriteLine("Çalışan Janset: " + calisan2.Ad + " " + calisan2.Soyad + " " + calisan2.Birim + " " + calisan2.SicilNo + " " + calisan2.GoreveBaslamaTarihi);

            Console.WriteLine("----------------------");

            Canta canta1 = new Canta();
            canta1.Hacim = 10.5;
            canta1.Agirlik = 2.3;
            Console.WriteLine("Çantanın hacmi = " + canta1.Hacim);
            Console.WriteLine("Çantanın ağırlığı = " + canta1.Agirlik);

        }
    }
}