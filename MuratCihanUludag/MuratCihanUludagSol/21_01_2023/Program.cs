namespace _21_01_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TurMethot();
            Bina();
        }
         public static void TurMethot()
        {
            Insan insan = new Insan();
            Tur tur = new Insan();
            tur.TurGoster(true);
            insan.CanliTuru = "Insan";
            insan.Familya = " HomoEraktus";
            insan.Aile = "Homo";
            insan.AileGoster();
            insan.FamilyaGoster();
            insan.TurGoster();
        }
        public static void Bina() 
        {
            Plaza plaza = new Plaza();
            Villa villa = new Villa();
            List<string> ofisListesi = new List<string>() { "ofise1", "ofise2", "ofise3" };
            List<string> odalarList = new List<string>() { "oda1", "oda1", "oda1" };
            plaza.KatSayisi = 2;
            plaza.AsansorluMu = true;
            plaza.Isin();
            plaza.SogukEngelle();
            plaza.Ofisler = ofisListesi;
            plaza.MesaBaslat();
            plaza.MesaBitir();
            villa.Odalar = odalarList;
            villa.AsansorluMu = false;
            villa.HavuzluMu(true);
            villa.SogukEngelle();
            villa.BahceSula();
            villa.Isin();

        }
    }
}