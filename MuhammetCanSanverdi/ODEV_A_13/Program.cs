using Microsoft.EntityFrameworkCore;

namespace ODEV_A_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Araba
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int PlakaId { get; set; }
        public int KisiId { get; set; }        
        public Plaka Plaka { get; set; }
        public Kisi Kisi { get; set; }
        public List<Muhendis> Muhendisler { get; set; }
    }
    public class Plaka
    {
        public int Id { get; set; }
        public string PlakaNo { get; set; }
        public Araba Araba { get; set; }
    }
    public class Kisi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Araba> Arabalar { get; set; }
    }
    public class Muhendis
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Araba> Arabalar { get; set; }
    }
}
