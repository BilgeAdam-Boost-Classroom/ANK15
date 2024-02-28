namespace Odev_A_24.Entities
{
    public class Oyun
    {
        private string _barkodNumarasi;

        public Oyun()
        {
            GenerateBarkod();
            BarkodNumarasi = _barkodNumarasi;

        }
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Paltform { get; set; }
        public string BarkodNumarasi
        {
            get { return _barkodNumarasi; }
            set { _barkodNumarasi = value; }
        }
        public bool tekPaltform { get; set; }
        public void GenerateBarkod()
        {
            Random random = new Random();

            for (int i = 0; i < 13; i++)
            {
                _barkodNumarasi += random.Next(10);
            }
        }
    }
}
