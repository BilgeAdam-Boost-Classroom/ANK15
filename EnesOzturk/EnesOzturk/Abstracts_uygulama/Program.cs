namespace Abstracts_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            İnsan insan = new İnsan();
            insan.Aile = "çekirdek";
            insan.Familya = "insan ";
            insan.CanliTuru = "insan";

            Console.WriteLine(insan);


        }
    }
}