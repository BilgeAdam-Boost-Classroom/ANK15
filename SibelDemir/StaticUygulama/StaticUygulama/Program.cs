namespace StaticUygulama
{
  public static class Program
    {
        public static void Main(params int[] sayilar)
        {
            int sayi1 = 5;
            int sayi2 = 10;
            int sayi3 = 15;

            double sonuc = ANK15.ucgen(sayi1, sayi2, sayi3);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        public static void Main(int toplam)
        {
            int sayi1 = 5;
            int sayi2 = 10;

            int sonuc = ANK15.Kare(sayi1, sayi2);

            Console.WriteLine("Sonuç: " + sonuc);
        }

         public static void Main(string[] args)
        {
            string kelime1 = "book";
            string kelime2 = "city";
            string kelime3 = "baby";

            string cogul1 = ANK15.Daire(kelime1);
            string cogul2 = ANK15.Daire(kelime2);
            string cogul3 = ANK15.Daire(kelime3);

            Console.WriteLine("Çoğul 1: " + cogul1);
            Console.WriteLine("Çoğul 2: " + cogul2);
            Console.WriteLine("Çoğul 3: " + cogul3);

        }
        
       

    }
}