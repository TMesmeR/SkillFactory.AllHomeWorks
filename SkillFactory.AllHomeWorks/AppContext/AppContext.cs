using Microsoft.EntityFrameworkCore;
using SkillFactory.AllHomeWorks.PreparForTable;

namespace SkillFactory.AllHomeWorks.AppContext
{
    internal class MyAppContext:DbContext
    {
        internal DbSet<Users> Users { get; set; }
        internal DbSet<Books> Books { get; set; }

        internal MyAppContext()
        {
           Database.EnsureDeleted();
           Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=ELibraryDatabase;Trusted_connection=true;
        TrustServerCertificate=True;");
        }
    }
}
