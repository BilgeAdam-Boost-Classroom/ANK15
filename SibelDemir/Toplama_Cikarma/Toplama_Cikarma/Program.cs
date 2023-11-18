namespace Toplama_Cikarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama topla = new Toplama(2, 3);
            Console.WriteLine(topla.topla());

            Cikarma cikar = new Cikarma(9, 6);
            Console.WriteLine(cikar.cikar());
        }
    }
}