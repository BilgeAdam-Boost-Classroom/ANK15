namespace Kisi_bilgisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Akademisyen akademisyen=new Akademisyen("Alp","Ceyhan");
            Ogrenci ogrenci=new Ogrenci("Sibel","Demir");
            IdariPersonel ıdariPersonel = new IdariPersonel("bilinmez","personel");

            akademisyen.makaleEkle("yazılım makalesi");

            int i= 0;
            foreach (var makale in akademisyen.Makaleler)
            {
                Console.WriteLine(akademisyen.Makaleler[i]);
                i++;

            }

        }
    }
}