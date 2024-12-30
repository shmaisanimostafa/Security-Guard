using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Security_Guard.Models; // Ensure this namespace contains the Tag and ArticleTag models
//using Security_Guard_API.Models;
using File = Shared.Models.File; // Your User model and other related models
using Shared.Models;


public class DBContext : IdentityDbContext<User>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PhishingEmail> PhishingEmails { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
    public DbSet<UserArticleInteraction> UserArticleInteractions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure many-to-many relationship between Article and Tag through ArticleTag
            modelBuilder.Entity<ArticleTag>()
                .HasKey(at => new { at.ArticleId, at.TagId });

            modelBuilder.Entity<ArticleTag>()
                .HasOne(at => at.Article)
                .WithMany(a => a.ArticleTags)
                .HasForeignKey(at => at.ArticleId);

            modelBuilder.Entity<ArticleTag>()
                .HasOne(at => at.Tag)
                .WithMany(t => t.ArticleTags)
                .HasForeignKey(at => at.TagId);

        // Configuring the relationship between Article and User
        modelBuilder.Entity<Article>()
            .HasOne(a => a.Author) // Each article has one Author
            .WithMany(u => u.Articles) // A User can have many Articles
            .HasForeignKey(a => a.AuthorId) // AuthorId is the foreign key
            .OnDelete(DeleteBehavior.NoAction); // Avoid cascade delete

        // Seed initial data if needed
        modelBuilder.SeedData();
        }
   }

