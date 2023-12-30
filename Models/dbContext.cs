using Microsoft.EntityFrameworkCore;

namespace Security_Guard.Models
{
    public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>().HasData(
                new File
                {
                    Id = 0,
                    UserName = "Mostafa",
                    FileName = "Virus.pdf",
                    DateTime = DateTime.Now,
                    URL = "www.virus.com"
                },
                new File
                {
                    Id = 1,
                    UserName = "Mostafa",
                    FileName = "Malware.pdf",
                    DateTime = DateTime.Now,
                    URL = "www.malware.ar"
                },
                new File
                {
                    Id = 2,
                    UserName = "Mostafa",
                    FileName = "potato.pdf",
                    DateTime = DateTime.Now,
                    URL = "www.potato.me"
                }
                
            );

        }

    }
}
