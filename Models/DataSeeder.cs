
using Microsoft.EntityFrameworkCore;
using Security_Guard.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Data
{
    public static class DataSeeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            SeedFiles(modelBuilder);
            SeedLinks(modelBuilder);
            SeedNeighbors(modelBuilder);
            // Add more seeding methods as needed
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

        private static void SeedNeighbors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Neighbor>().HasData(
             new Neighbor()
             {
                 Id = 1,
                 Rating = 3,
                 Description = "Do you want to see the sea? This your best Hotel",
                 Name = "Bitdefender",
                 URL = "https://www.bitdefender.com/",
                 ImgURL = "file://C:/Users/shmai/source/repos/Security%20Guard/wwwroot/Neighbors/Bitdefender.png"
             },
            new Neighbor()
            {
                Id = 2,
                Rating = 5,
                Description = "The best for the best. The place where you can exercise your hiking and other sports.",
                Name = "Dr.Web",
                URL = "https://www.drweb.com/",
                ImgURL = "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png"
            },
            new Neighbor()
            {
                Id = 3,
                Rating = 4,
                Description = "Sleep for cheap. Cheapest Hotel you may ever found",
                Name = "eset",
                URL = "https://www.eset.com/",
                ImgURL = "https://c4.wallpaperflare.com/wallpaper/813/904/915/hotel-new-york-statue-of-liberty-in-las-vegas-nevada-usa-hd-desktop-wallpaper-1920%C3%971200-wallpaper-preview.jpg"
            },
            new Neighbor()
            {
                Id = 4,
                Rating = 3,
                Description = "Do you want to see the sea? This your best Hotel",
                Name = "Kaspersky",
                URL = "https://me-en.kaspersky.com/",
                ImgURL = "https://wallpapershome.com/images/pages/ico_h/655.jpg"
            },
            new Neighbor()
            {
                Id = 5,
                Rating = 1,
                Description = "The best for the best. The place where you can exercise your hiking and other sports.",
                Name = "PhishTank",
                URL = "https://phishtank.org/",
                ImgURL = "https://www.thesouthafrican.com/wp-content/uploads/2022/07/hotel-800x529.png"
            },
            new Neighbor()
            {
                Id = 6,
                Rating = 2,
                Description = "Sleep for cheap. Cheapest Hotel you may ever found",
                Name = "VirusTotal",
                URL = "https://www.virustotal.com/gui/home/upload",
                ImgURL = "https://wallpapercave.com/wp/wp12549190.jpg"
            }
            );
        }
    }
}