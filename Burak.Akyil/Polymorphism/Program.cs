namespace Polymorphism
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

            List<Hayvan> hayvanatBahcesi = new List<Hayvan>();
            //hayvanatBahcesi.Add(hayvan1);
            //hayvanatBahcesi.Add(kedi1);
            //hayvanatBahcesi.Add(canli);

            HayvanGetir(hayvan1);
            HayvanGetir(kedi1);
            HayvanGetir(canli);

            void HayvanGetir(Hayvan hayvan)
            {
                hayvanatBahcesi.Add(hayvan);
            }
        }
    }
}