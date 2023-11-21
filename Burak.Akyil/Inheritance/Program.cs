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
            
            Thread.Sleep(2000);
            Console.Clear();

            Akademisyen akademisyen = new Akademisyen("Caner", "Özdemir");
            Ogrenci ogrenci = new Ogrenci("Burak", "Akyıl");
            IdariPersonel idariPersonel = new IdariPersonel("Sadettin", "Akyıl");

            ogrenci.Bolum = "Mühendislik";
            ogrenci.DersEkle("Termodinamik");
            ogrenci.DersEkle("Matematik");

            idariPersonel.Birimi = "IT";

            akademisyen.MakaleEkle("Araştırma 1");
            akademisyen.MakaleEkle("Araştırma 2");

            foreach (var makale in akademisyen.Makaleler)
            {
                Console.WriteLine(makale);
            }
            Console.WriteLine("-----------------");
            foreach (var ders in ogrenci.Dersler)
            {
                Console.WriteLine(ders);
            }



        }
    }
}