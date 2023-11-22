namespace Poliformizm_gorev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan= new Hayvan();
            hayvan.Kos();
            Kedi kedi= new Kedi();
            kedi.Kos();
            Hayvan canli= new Hayvan();
            canli.Kos();
            Hayvan canli1=new Kedi(); //tam tersi olmaz

            canli1.Kos();

            List<Hayvan> hayvanatbahcesi = new List<Hayvan>();
            hayvanatbahcesi.Add(hayvan);
            hayvanatbahcesi.Add(kedi);
            hayvanatbahcesi.Add(canli1);
            hayvanatbahcesi.Add(canli);
       
           


            void HayvanGetir(Hayvan hayvan)   //metot yöntemi ile
            {
                hayvanatbahcesi.Add(hayvan);
            }

        }
    }
}