namespace Geometrik_Şekiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometrikSekil geometrikSekil = new GeometrikSekil();
            Dikdortgen dikdortgen = new Dikdortgen();
            Kare kare = new Kare();
            kare.Genislik = 4;
            kare.Yükseklik = 5;
            dikdortgen.Yükseklik = 5;
            dikdortgen.Genislik = 6;
            geometrikSekil.Yükseklik = 3;
            geometrikSekil.Genislik = 9;
            Console.WriteLine(kare.AlanHesapla());
            Console.WriteLine(dikdortgen.CevreHesapla());
            Console.WriteLine(geometrikSekil.AlanHesapla());
        }
    }
}