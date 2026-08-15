namespace SkillFactory.AllHomeWorks.PreparForTable
{
    internal class Books
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public int YearOfRelease { get; set; }

        public string Author { get; set; }
        public string BookGenre {  get; set; }
        public List<Users> Users { get; set; }
    }
}
