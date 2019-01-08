using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityFitChallenge.Web.Data
{
    public class CommunityFitDbContext : IdentityDbContext
    {
        public CommunityFitDbContext(DbContextOptions<CommunityFitDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<CommunityFitUser> Users { get; set; }
    }
}