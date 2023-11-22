namespace Tur_bilgisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan =new Insan();
            insan.Familya = "Hominidae";
            insan.Aile = "Babayiğit";
            insan.CanliTuru = "Homo sapiens";

            insan.FamilyaGoster();
            
            insan.AileGoster();
        }
    }
}
