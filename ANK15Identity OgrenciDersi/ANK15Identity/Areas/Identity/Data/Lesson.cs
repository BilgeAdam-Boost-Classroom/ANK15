namespace ANK15Identity.Areas.Identity.Data
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }

        public List<ANK15IdentityUser> Users { get; set; }
    }
}
