namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Canli("Beril","27");
            Kopek kopek = new Kopek("Köpük","3");
            Kedi kedi = new Kedi("Bozo","2");

            canli.SesCikar();
            kedi.SesCikar();
            kopek.SesCikar();
        }
    }
}