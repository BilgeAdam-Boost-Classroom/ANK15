namespace canli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Canli("Genel Canlı", 5);
            Console.WriteLine("Canli Nesnesi:");
            Console.WriteLine($"Ad: {canli.Ad}, Yas: {canli.Yas}");
            
            Kedi kedi = new Kedi("Şeref", 4);
            Console.WriteLine("\nKedi Nesnesi:");
            Console.WriteLine($"Ad: {kedi.Ad}, Yas: {kedi.Yas}");

            Kopek kopek = new Kopek("Fifi", 3);
            Console.WriteLine("\nKopek Nesnesi:");
            Console.WriteLine($"Ad: {kopek.Ad}, Yas: {kopek.Yas}");


            Console.WriteLine("\nSes Çıkarma:");
            canli.SesCikar();
            kedi.SesCikar();
            kopek.SesCikar();
        }
    }
}