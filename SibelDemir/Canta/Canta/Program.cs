using System.Text;

namespace Canta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canta canta = new Canta();
            
            canta.hacim = 10;
            canta.agirlik = -2;
            Console.WriteLine($"Çanta Hacmi: {canta.hacim}");
            Console.WriteLine($"Çanta Ağırlığı: {canta.agirlik}");

        }
    }
}