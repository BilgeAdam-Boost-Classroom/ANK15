namespace Calisanlar_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan=new Calisan("Sibel","Demir","Yazılım",DateTime.Parse("24/05/2023"),"A13");
            Console.WriteLine(calisan.sicilNo);
        }
    }
}