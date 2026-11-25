using SortaTask.Models;
using Microsoft.EntityFrameworkCore;

namespace SortaTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /*public DbSet<Users> User { get; set; }
        public DbSet<Subjects> Subject { get; set; }
        public DbSet<StudyTasks> StudyTask { get; set; }
        public DbSet<StudyNotes> StudyNote { get; set; }*/
    }
}
