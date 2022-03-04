using Microsoft.EntityFrameworkCore;

namespace efMvcDemo.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=efmvc1;Integrated Security=SSPI;");
        }
    }
}
