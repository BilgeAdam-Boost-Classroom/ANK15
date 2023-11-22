namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plaza plaza = new Plaza();
            plaza.KatSayisi = 30;
            plaza.AsansorluMu = true;
            plaza.Ofisler.Capacity = 40;
            

            Villa villa = new Villa();
            villa.KatSayisi = 4;
            villa.AsansorluMu = false;
            villa.HavuzluMu = true;
            villa.Odalar.Capacity = 5;

            Console.WriteLine("Plazanın katsayısı: " + plaza.KatSayisi + ", Plaza asansörlü mü: " + plaza.AsansorluMu + ", Plazanın ofis sayısı: " + plaza.Ofisler.Capacity);
            plaza.Isin();
            plaza.SogukEngelle();
            plaza.MesaiBaslat();
            plaza.MesaiBitir();

            Console.WriteLine("------------------------");

            Console.WriteLine("Villanın katsayısı: " + villa.KatSayisi + ", Villa asansörlü mü: " + villa.AsansorluMu + ", Villa havuzlu mu: " + villa.HavuzluMu + ", Villanın oda sayısı: " + villa.Odalar.Capacity);
            villa.Isin();
            villa.SogukEngelle();
            villa.BahceSula();



        }
    }
}