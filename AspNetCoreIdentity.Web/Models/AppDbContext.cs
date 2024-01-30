using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Web.Models
{
    
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {

        public DbSet<SiteUserGroup> SiteUserGroup { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<UserAndGroupMatching> UserAndGroupMatching { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
