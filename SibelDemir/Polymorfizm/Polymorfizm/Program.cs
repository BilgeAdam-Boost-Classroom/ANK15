using System.Security.Cryptography.X509Certificates;

namespace Polymorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan1 = new Hayvan();
            hayvan1.Kos();

            Kedi kedi1 = new Kedi();
            kedi1.Kos();


            Hayvan canli = new Kedi();//tipi hayvan ama kedi gibi de davranabir.
            canli.Kos();

            List<Hayvan>hayvanatBahcesi=new List<Hayvan>();
            hayvanatBahcesi.Add(hayvan1);
            hayvanatBahcesi.Add(kedi1 );
            hayvanatBahcesi.Add(canli);

            void HayvanGetir(Hayvan hayvan)
            {
                hayvanatBahcesi.Add(hayvan);
            }
        }

    }
}