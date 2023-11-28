namespace Bina_Bilgisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plaza plaza = new Plaza();

            plaza.KatSayisi = 5;
            plaza.AsansorluMu = true;

            plaza.OfisEkle("Ofis 1");
            plaza.OfisEkle("Ofis 2");
            plaza.OfisEkle("Ofis 3");


            plaza.OfisleriListele();


            plaza.MesaiBaslat();


            plaza.MesaiBitir();


            Villa villa = new Villa();
            villa.AsansorluMu = false;
            villa.KatSayisi = 2;
            villa.HavuzluMu = true;

            villa.BahceSula();


            villa.OdaEkle("Çalışma Odası");
            villa.OdaEkle("Oyun Odası");
            villa.OdaEkle("Dinlenme Odası");


            villa.OdalariListele();



        }
    }
}