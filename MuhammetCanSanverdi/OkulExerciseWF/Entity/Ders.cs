namespace OkulExerciseWF.Entity
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public int Kredi { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public override string ToString()
        {
            return Ad + " " + Kod + " " + Kredi;
        }
    }
}
