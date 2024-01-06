namespace OkulExerciseWF.Entity
{
    public class Danisman
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public override string ToString()
        {
            return Ad + " " + Soyad ;
        }
    }
}
