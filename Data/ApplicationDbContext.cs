using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Goals_Site.Models;

namespace Goals_Site.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<Goals_Site.Models.Quote> Quotes { get; set; }
        public DbSet<Goals_Site.Models.Site> Sites { get; set; }
        public DbSet<Goals_Site.Models.Client> Clients { get; set; }
        public DbSet<Goals_Site.Models.Manager> Managers { get; set; }
        public DbSet<Goals_Site.Models.Job> Jobs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>()
                .HasMany(q => q.Jobs);
        }
    }
}