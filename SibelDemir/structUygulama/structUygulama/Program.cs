namespace structUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutuphane Ank15Kutuphane = new Kutuphane();
            Ank15Kutuphane.Ad = "Ank15Kutuphane";
            Ank15Kutuphane.Alan = 20;
            Ank15Kutuphane.KitapOduncVer();
            Ank15Kutuphane.Kitaplar = new List<string>();
            Ank15Kutuphane.Kitaplar.Add("Serenad");
            Ank15Kutuphane.Kitaplar.Add("Kürk Mantolu Madonna");

            for (int i = 0; i < Ank15Kutuphane.Kitaplar.Count; i++)
            {
                Console.WriteLine(Ank15Kutuphane.Kitaplar[i]);
            }
        }
    }
}