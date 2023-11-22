using OOP_Polymorphism.Siniflar;

namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan1 = new Hayvan();
            hayvan1.Kos();

            Kedi kedi1 = new Kedi();
            kedi1.Kos();

            Hayvan canli = new Kedi();
            canli.Kos();
        }
    }
}