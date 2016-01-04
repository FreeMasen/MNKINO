using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace MNKINO.Models
{
    public class MnkinoContext : DbContext
    {

        public MnkinoContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = Startup.Configuration["data:MNKINOConnection"];
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
