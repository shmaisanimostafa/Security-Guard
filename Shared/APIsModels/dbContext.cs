//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;
//using Security_Guard.Data;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Security_Guard_API.Models;
//using Microsoft.AspNetCore.Identity;
//using Shared.Models;

//namespace Security_Guard.Models
//{
//    public class DBContext : IdentityDbContext<User>
//    {
//        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
//        public DbSet<ArticleOld> Articles { get; set; }
//        public DbSet<FileOld> Files { get; set; }
//        public DbSet<Link> Links { get; set; }
//        public DbSet<Report> Reports { get; set; }
//        public DbSet<Message> Messages { get; set; }


//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.SeedData();
//        }

//    }
//} 
