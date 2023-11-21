namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometrikSekil geometrikSekil = new GeometrikSekil();
            Console.WriteLine("Genişlik giriniz.");
            geometrikSekil.Genislik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yükseklik giriniz.");
            geometrikSekil.Yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çevre = " + geometrikSekil.CevreHesapla());
            Console.WriteLine("Alan = " + geometrikSekil.AlanHesapla());
            Console.WriteLine("----------------------");
            Kare kare = new Kare();
            Console.WriteLine("Genişlik giriniz.");
            kare.Genislik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yükseklik giriniz.");
            kare.Yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çevre = " + kare.CevreHesapla());
            Console.WriteLine("Alan = " + kare.AlanHesapla());
            Console.WriteLine("----------------------");
            Dikdortgen dikdortgen = new Dikdortgen();
            Console.WriteLine("Genişlik giriniz.");
            dikdortgen.Genislik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yükseklik giriniz.");
            dikdortgen.Yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çevre = " + dikdortgen.CevreHesapla());
            Console.WriteLine("Alan = " + dikdortgen.AlanHesapla());
            Console.Clear();

        }
    }
}