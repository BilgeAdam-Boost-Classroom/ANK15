namespace Odev3_Hesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama toplama = new Toplama(5,2);
            Cikarma cikarma = new Cikarma(5,2);

            Console.WriteLine(toplama.Topla());
            Console.WriteLine(cikarma.Cikar()); 
        }
    }
}