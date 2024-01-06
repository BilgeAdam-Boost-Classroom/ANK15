namespace SchoolExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public int DiplomaId { get; set; }
        public int DanismanId { get; set; }
        public Diploma Diploma { get; set; }
        public Danisman Danisman { get; set; }
        public List<Ders> Dersler { get; set; }
    }

    public class Diploma
    {
        public int Id { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }

    public class Danisman
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int Kredi { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
    public class OgrenciDers
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int Not { get; set; }
    }
}
