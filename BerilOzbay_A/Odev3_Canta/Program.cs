namespace Odev3_Canta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canta canta = new Canta();
            canta.Agırlık = -20;
            canta.Hacim = -40;
            Console.WriteLine("Cantanin Hacmi:" + canta.Hacim + " "+ "Cantanin Agirligi:" + canta.Agırlık);
        }
    }
}