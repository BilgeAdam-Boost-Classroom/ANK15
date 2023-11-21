namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Canli("Canlı", 4);
            Kopek kopek = new Kopek("Dost", 5);
            Kedi kedi = new Kedi("Köfte", 1);

            Console.WriteLine("Canlının ismi: " + canli.Ad + " - " + "Canlının yaşı: " + canli.Yas);
            canli.SesCikar();
            Console.WriteLine("Köpeğin ismi: " + kopek.Ad + " - " + "Köpeğin yaşı: " + kopek.Yas);
            kopek.SesCikar();
            Console.WriteLine("Kednin ismi: " + kedi.Ad + " - " + "Kedinin yaşı: " + kedi.Yas);
            kedi.SesCikar();
        }
    }
}