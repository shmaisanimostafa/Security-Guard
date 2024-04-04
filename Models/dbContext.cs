using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Security_Guard.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Security_Guard.Models
{
    public class DBContext : IdentityDbContext<User>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Report> Reports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();
        }

    }
}
