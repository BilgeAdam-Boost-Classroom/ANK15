namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ank15.Nufus = "13";
            Console.WriteLine(Ank15.Nufus);
            Console.WriteLine(Ank15.Ucgen(5));
            Console.WriteLine(Ank15.Kare(5, 8));
            Console.WriteLine(Ank15.Daire("Care"));
            Console.WriteLine(Ank15.Daire("Identity"));
        }
    }
}