using Odev_3_2.Class;
using Odev_3_2.Class.Calisan;
using Odev_3_2.Class.Canta;

namespace Odev_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToplaCikar();
            CalisanMetot();

            Canta canta = new Canta();
            Canta canta2 = new Canta();

            canta.Hacim = -12;
            canta.Agirlik = -12;

            canta2.Hacim = 12; 
            canta2.Agirlik = 123;

            Console.WriteLine($"Hacim: {canta.Hacim} Agirlik: {canta.Agirlik}");
            Console.WriteLine($"Hacim: {canta2.Hacim} Agirlik: {canta2.Agirlik}");
        }
        public static void ToplaCikar()
        {

            double sayi1 = 12.5;
            double sayi2 = 13.4;

            Toplama topla = new Toplama(sayi1, sayi2);
            Cikarma cikar = new Cikarma(sayi1, sayi2);

            Console.WriteLine($"Toplama isleminin sonucu : {topla.Topla()}");
            Console.WriteLine($"Cikarma isleminin sonucu : {cikar.Cikar()}");
        }
        public static void CalisanMetot()
        {
            DateTime time = DateTime.Now;

            Calisan calisan = new Calisan("Cihan", "Uludag", "A123", time) ;

            Console.WriteLine(calisan.ToString());
        }
    }
}