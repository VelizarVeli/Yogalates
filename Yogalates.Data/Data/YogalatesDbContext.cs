using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yogalates.Models;

namespace Yogalates.Data.Data
{
    public class YogalatesDbContext : IdentityDbContext<YogalatesUser>
    {
        public YogalatesDbContext(DbContextOptions<YogalatesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
