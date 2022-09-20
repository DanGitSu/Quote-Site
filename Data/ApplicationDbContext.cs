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
        public DbSet<Goals_Site.Models.Site> Site { get; set; }
        public DbSet<Goals_Site.Models.Client> Client { get; set; }
       
    }
}