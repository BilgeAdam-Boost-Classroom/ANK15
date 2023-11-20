namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Canli();
            Kopek kopek = new Kopek();
            Kedi kedi = new Kedi();

            canli.SesCikar();
            kedi.SesCikar();
            kopek.SesCikar();
        }
    }
}