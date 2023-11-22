using GeometrikSekil.Geometri;
using GeometrikSekil.Okul;

namespace GeometrikSekil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometrikSekiller();
            Okul();
        }
        public static void GeometrikSekiller()
        {

            double yukseklik = 12.4;
            double genislik = 9.23;
            Kare kare = new Kare() { Genislik = genislik, Yukseklik = yukseklik };
            Dikdortgen dikdortgen = new Dikdortgen() { Genislik = genislik, Yukseklik = yukseklik };
            Console.WriteLine($"Kare\n{new string('-', count: 50)}\nCevre = {kare.CevreHesap()} Alan = {kare.AlanHesabi()}");
            Console.WriteLine(new string('-', count: 50));
            Console.WriteLine($"Dikdortgen\n{new string('-', count: 50)}\nCevre = {dikdortgen.CevreHesap()} Alan = {dikdortgen.AlanHesabi()}");
        }
        public static void Okul() 
        {
            Akademisyen akademisyen = new Akademisyen();
            Ogrenci ogrenci = new Ogrenci();    

            List<string> list = new List<string>() { "makale1", "makale2" };
            akademisyen.Name = "isim-1";
            akademisyen.Surname = "soyisim-1";
            akademisyen.MakaleEkle(list);

            ogrenci.Name = "Cihan";
            ogrenci.Surname = "uludag";
            ogrenci.Bolum = "Mekatronik Muh";

            ogrenci.DersEkle("FIZIK1");
            ogrenci.DersEkle("FIZIK2");
            ogrenci.DersEkle("FIZIK3");

            Console.WriteLine($"Ogrenci isim ; {ogrenci.Name}\n" +
                $"SoyIsim = {ogrenci.Surname}\n" +
                $"Ogrenci Bolum = {ogrenci.Bolum}\n" +
                $"Ogrenci Dersleri ={ogrenci.DersGoster()}");

            Console.WriteLine($"Akademisyen isim: {akademisyen.Name}\n" +
                $"soyIsim = {akademisyen.Surname}\n" +
                $"Makaleleri = {akademisyen.MakaleGoster()}");
        }
    }
}