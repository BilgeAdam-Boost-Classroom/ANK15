using Odev_4.Model;

namespace Odev_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli kedi = new Kedi();
            Canli kopek = new Kopek();

            kedi.SesCikar();
            kopek.SesCikar();   
        }
    }
}