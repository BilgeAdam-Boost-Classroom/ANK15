namespace OkulExerciseWF.Entity
{
    public class Diploma
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int No { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
