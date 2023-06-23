using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Add> Adds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Add>().HasKey(x => x.Id);
            modelBuilder.Entity<Add>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}