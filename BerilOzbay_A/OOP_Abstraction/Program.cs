namespace OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insan insan = new Insan();
            //insan.Aile = "Ozbay";
            //insan.Familya = "Memeli";
            //insan.CanliTuru = "Insan";

            //insan.AileGoster();
            //insan.FamilyaGoster();
            //insan.TurGoster();

            Plaza plaza = new Plaza();
            Villa villa = new Villa();
            plaza.AsansorluMu = true;
            plaza.KatSayisi = 60;
            plaza.Ofisler.Add("Yazılım");
            plaza.Ofisler.Add("Analiz");
            plaza.SogukEngelle();
            plaza.Isin();
            plaza.MesaiBaslat();
            plaza.MesaiBitir();

            Console.WriteLine(plaza.KatSayisi+ " "+ plaza.AsansorluMu + "");
            foreach (var item in plaza.Ofisler)
            {
                Console.WriteLine(item);
            }

            villa.Odalar.Add("Yatak odasi");
            villa.Odalar.Add("Oturma odasi");
            villa.HavuzluMu = true;
            villa.AsansorluMu = true;
            villa.KatSayisi = 4;
            villa.BahceSula();
            villa.Isin();
            villa.SogukEngelle();

            Console.WriteLine(villa.KatSayisi + " " + villa.AsansorluMu + "");
            foreach (var item in villa.Odalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}