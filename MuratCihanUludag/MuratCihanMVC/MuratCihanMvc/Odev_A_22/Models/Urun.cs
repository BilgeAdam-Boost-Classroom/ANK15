namespace Odev_A_22.Models
{
    public class Urun
    {
        private int _numara;
        public Urun()
        {
            _numara = new Random().Next(1, 11);
            Numara = _numara;
        }
        public int Numara { get; }
    }
}
