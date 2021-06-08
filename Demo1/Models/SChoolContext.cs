using Microsoft.EntityFrameworkCore;

namespace Demo1.Models
{
    public class SChoolContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=.;Database=demo5;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }

}