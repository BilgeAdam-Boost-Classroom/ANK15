namespace GeometriUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GeometriSekil geometriSekil = new GeometriSekil();

            Kare kare = new Kare();

            kare.Genislik = 5;
            kare.Yukseklik = 5;

            Console.WriteLine("Karenin Çevresi :  " + kare.CevreHesapla());
            Console.WriteLine("Karenin Alanı  : " + kare.AlanHesapla());

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.Genislik = 5;
            dikdortgen.Yukseklik = 10;

            Console.WriteLine("dikdörtgen çevresi : " + dikdortgen.CevreHesapla());
            Console.WriteLine( "Dikdörtgen Alanı : " + dikdortgen.AlanHesapla());



        }
    }
}