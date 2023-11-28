namespace Delegate_27_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 8;
            double sayi2 = 12.12;
            string kelime = "Test123";
            F(kelime, sayi, sayi2, Toplam);
     
        }
        public delegate int Temsilci1(int x, double y);

        public delegate void Temsilci2(double x);

        public delegate double Temsilci3(List<double> a);
        static int Toplam(int x, double y)
        {
            return (int)(x + y);
        }
        static double OrtalamaHesapla(List<double> x)
        {
            return x.Average();
        }
        static void F(string s, int x, double y, Temsilci1 temsilci1)
        {
            temsilci1(x,y);
        }
        static void K(string s , double y , Temsilci2 temsilci2)
        {
            temsilci2(y);
        }
        static double Sonuc (List<double> x , Temsilci3 temsilci3)
        {
            return temsilci3(x);
        }
        
    
    }
}