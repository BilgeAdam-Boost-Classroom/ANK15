namespace GeometriOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesap hesap= new Hesap();
            hesap.Aci = 360; // 0 ile 360 dışında bir değer girilidğinde uyarı veriyor.

            Console.WriteLine(  hesap.Aci);
        }
    }
}