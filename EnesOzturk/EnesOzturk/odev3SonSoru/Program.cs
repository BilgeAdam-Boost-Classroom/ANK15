namespace odev3SonSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canta canta = new Canta();

            canta.Agirlik = -2;
            canta.Hacim = 2;
            Console.WriteLine(canta.Agirlik);
            Console.WriteLine(canta.Hacim);

        }
    }
}