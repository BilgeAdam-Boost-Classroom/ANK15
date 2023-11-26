using ConsoleApp24_11_2023.Siniflar;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp24_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Ucgen.IstediginKadarSayo(2, 3, 4, 5, 6));
            Console.WriteLine(Kare.MetotKare(5, 5));
            Console.WriteLine(Daire.Kelime("Cihany"));
            Console.WriteLine(Nufus.NufusSayisi);
        }

    }
}