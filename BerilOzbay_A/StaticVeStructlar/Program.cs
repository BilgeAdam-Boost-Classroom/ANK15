namespace StaticVeStructlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ANK15.Ucgen(1, 2, 3));
            Console.WriteLine(ANK15.Kare(5,7));
            Console.WriteLine(ANK15.Daire("Bus"));
            Console.WriteLine(ANK15.Daire("Baby"));

            ANK15.Nufus = 13; 
            Console.WriteLine(ANK15.Nufus);

        }
    }
}