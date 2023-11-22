using Console22_11_2023.Siniflar;

namespace Console22_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hayvan hayvan1 = new Hayvan();
            hayvan1.Name = "Hayvan";
            hayvan1.Kosmak();

            Kedi kedi1 = new Kedi();
            kedi1.Name = "Tekir";
            kedi1.Kosmak();

            Hayvan canli = new Kedi();
            canli.Name = "Biritsh";
            canli.Kosmak();

            //Kedi canli2 = (Kedi)new Hayvan();
            //canli2.Kosmak();     Bu olmaz hata atar sebibi dar tipi genis tipe donusturmeye calisiyorsun ama run time hatasi alirsin.

            List<Hayvan> hayvanatBahcesi = new List<Hayvan>();  
            //hayvanatBahcesi.Add(hayvan1);
            //hayvanatBahcesi.Add(kedi1);
            //hayvanatBahcesi.Add(canli);

            HayvanGetir(hayvan1, hayvanatBahcesi);
            HayvanGetir(kedi1, hayvanatBahcesi);
            HayvanGetir(canli, hayvanatBahcesi);
            Console.WriteLine(string.Join(", ",hayvanatBahcesi));

        }
        public static void HayvanGetir(Hayvan hayvan,List<Hayvan> hayvanListesi)
        {
            hayvanListesi.Add(hayvan);  

        }
    }
}