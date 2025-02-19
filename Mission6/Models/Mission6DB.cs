using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class Mission6DB : DbContext
    {
        public Mission6DB(DbContextOptions<Mission6DB> options) : base(options)
        {
        }

        public DbSet<Application> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasKey(m => m.MovieId); // Define MovieId as primary key
            modelBuilder.Entity<Categories>()
               .HasKey(m => m.CategoryId); // Define CategoryId as primary key
        }   
    }
}
