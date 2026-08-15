namespace SkillFactory.AllHomeWorks.PreparForTable
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Books> Books { get; set; }
    }
}
