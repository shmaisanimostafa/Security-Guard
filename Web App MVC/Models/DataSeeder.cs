
using Microsoft.EntityFrameworkCore;
using Security_Guard.Models;
using Security_Guard_API.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Data
{
    public static class DataSeeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            SeedFiles(modelBuilder);
            SeedLinks(modelBuilder);
            SeedArticles(modelBuilder);
            SeedMessages(modelBuilder);
            // Add more seeding methods as needed
        }

        private static void SeedMessages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    Id = 0,
                    Text = "Hello",
                    Sender = "Mostafa",
                    IsAi = false,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 1,
                    Text = "Hi",
                    Sender = "AI",
                    IsAi = true,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 2,
                    Text = "How are you?",
                    Sender = "Mostafa",
                    IsAi = false,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 3,
                    Text = "I'm fine",
                    Sender = "AI",
                    IsAi = true,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 4,
                    Text = "Good",
                    Sender = "Mostafa",
                    IsAi = false,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 5,
                    Text = "Bye",
                    Sender = "AI",
                    IsAi = true,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 6,
                    Text = "Bye",
                    Sender = "Mostafa",
                    IsAi = false,
                    Time = DateTime.Now
                },
                new Message
                {
                    Id = 7,
                    Text = "Goodbye",
                    Sender = "AI",
                    IsAi = true,
                    Time = DateTime.Now
                }


                );
        }

        private static void SeedFiles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>().HasData(
            new File
            {
                Id = 0,
                UserName = "Mostafa",
                FileName = "Virus.pdf",
                DateTime = DateTime.Now,
                URL = "www.virus.com",
                Status = "danger"
            },
            new File
            {
                Id = 1,
                UserName = "Mostafa",
                FileName = "Malware.pdf",
                DateTime = DateTime.Now,
                URL = "www.malware.ar",
                Status = "danger"
            },
            new File
            {
                Id = 2,
                UserName = "Mostafa",
                FileName = "potato.pdf",
                DateTime = DateTime.Now,
                URL = "www.potato.me",
                Status = "danger"
            },
            new File
            {
                Id = 3,
                UserName = "Mostafa",
                FileName = "Virus.pdf",
                DateTime = DateTime.Now,
                URL = "www.virus.com",
                Status = "safe"
            },
            new File
            {
                Id = 4,
                UserName = "Mostafa",
                FileName = "Malware.pdf",
                DateTime = DateTime.Now,
                URL = "www.malware.ar",
                Status = "safe"
            },
            new File
            {
                Id = 5,
                UserName = "Mostafa",
                FileName = "potato.pdf",
                DateTime = DateTime.Now,
                URL = "www.potato.me",
                Status = "ambigious"
            }
            );
        }

        private static void SeedLinks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>().HasData(
            new Link
            {
                Id = 0,
                UserName = "Mostafa",
                DateTime = DateTime.Now,
                URL = "www.pdf.com.lb.mu.edu",
                Status = "danger"
            },
            new Link
            {
                Id = 1,
                UserName = "Mostafa",
                DateTime = DateTime.Now,
                URL = "www.trojans.ar",
                Status = "safe"
            },
            new Link
            {
                Id = 2,
                UserName = "Mostafa",
                DateTime = DateTime.Now,
                URL = "www.malosd.me",
                Status = "ambigious"
            }
            );
        }

        private static void SeedArticles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
             new Article()
             {
                 Id = 1,
                 Rating = 3,
                 Content = "Do you want to see the sea? This your best Hotel",
                 Title = "Bitdefender",
                 SourceURL = "https://www.bitdefender.com/",
                 ImageURL = "file://C:/Users/shmai/source/repos/Security%20Guard/wwwroot/Neighbors/Bitdefender.png"
             },
            new Article()
            {
                Id = 2,
                Rating = 5,
                Content = "The best for the best. The place where you can exercise your hiking and other sports.",
                Title = "Dr.Web",
                SourceURL = "https://www.drweb.com/",
                ImageURL = "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png"
            },

            new Article()
            {
                Id = 7,
                Rating = 5,
                Content = "> Hi \n # What do you have today \n \"Good\" `Morning`  ",
                Title = "Markdown",
                SourceURL = "https://www.drweb.com/",
                ImageURL = "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png"
            },

            new Article()
            {
                Id = 3,
                Rating = 4,
                Content = "Sleep for cheap. Cheapest Hotel you may ever found",
                Title = "eset",
                SourceURL = "https://www.eset.com/",
                ImageURL = "https://c4.wallpaperflare.com/wallpaper/813/904/915/hotel-new-york-statue-of-liberty-in-las-vegas-nevada-usa-hd-desktop-wallpaper-1920%C3%971200-wallpaper-preview.jpg"
            },
            new Article()
            {
                Id = 4,
                Rating = 3,
                Content = "Do you want to see the sea? This your best Hotel",
                Title = "Kaspersky",
                SourceURL = "https://me-en.kaspersky.com/",
                ImageURL = "https://wallpapershome.com/images/pages/ico_h/655.jpg"
            },
            new Article()
            {
                Id = 5,
                Rating = 1,
                Content = "The best for the best. The place where you can exercise your hiking and other sports.",
                Title = "PhishTank",
                SourceURL = "https://phishtank.org/",
                ImageURL = "https://www.thesouthafrican.com/wp-content/uploads/2022/07/hotel-800x529.png"
            },
            new Article()
            {
                Id = 6,
                Rating = 2,
                Content = "Sleep for cheap. Cheapest Hotel you may ever found",
                Title = "VirusTotal",
                SourceURL = "https://www.virustotal.com/gui/home/upload",
                ImageURL = "https://wallpapercave.com/wp/wp12549190.jpg"
            }
            );
        }
    }
}