using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;

namespace Security_Guard.Controllers
{
    public class NeighborsController : Controller
    {
        private static List<Neighbor> Neighbors { get; set; } = new()
    {
        new Neighbor()
        {
          Id = 0,
          Rating = 3,
          Description = "Do you want to see the sea? This your best Hotel",
          Name = "Bitdefender",
          URL = "https://www.bitdefender.com/",
          ImgURL="file://C:/Users/shmai/source/repos/Security%20Guard/wwwroot/Neighbors/Bitdefender.png"
        },
        new Neighbor()
        {
          Id = 1,
          Rating = 5,
          Description = "The best for the best. The place where you can exercise your hiking and other sports.",
          Name = "Dr.Web",
          URL = "https://www.drweb.com/",
          ImgURL="file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png"
        },
        new Neighbor()
        {
          Id = 2,
          Rating = 4,
          Description = "Sleep for cheap. Cheapest Hotel you may ever found",
          Name = "eset",
          URL="https://www.eset.com/",
          ImgURL="https://c4.wallpaperflare.com/wallpaper/813/904/915/hotel-new-york-statue-of-liberty-in-las-vegas-nevada-usa-hd-desktop-wallpaper-1920%C3%971200-wallpaper-preview.jpg"
        },
        new Neighbor()
        {
          Id = 3,
          Rating = 3,
          Description = "Do you want to see the sea? This your best Hotel",
          Name = "Kaspersky",
          URL="https://me-en.kaspersky.com/",
          ImgURL="https://wallpapershome.com/images/pages/ico_h/655.jpg"
        },
        new Neighbor()
        {
          Id = 4,
          Rating = 1,
          Description = "The best for the best. The place where you can exercise your hiking and other sports.",
          Name = "PhishTank",
          URL="https://phishtank.org/",
          ImgURL="https://www.thesouthafrican.com/wp-content/uploads/2022/07/hotel-800x529.png"
        },
        new Neighbor()
        {
          Id = 5,
          Rating = 2,
          Description = "Sleep for cheap. Cheapest Hotel you may ever found",
          Name = "VirusTotal",
          URL="https://www.virustotal.com/gui/home/upload",
          ImgURL="https://wallpapercave.com/wp/wp12549190.jpg"
        }
    };
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Neighbors = Neighbors;
            return View();
        }
        [HttpGet]
        public IActionResult AddNeighbor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var hotelToDelete = Neighbors.Find(h => h.Id == id);

            if (hotelToDelete != null)
            {
                Neighbors.Remove(hotelToDelete);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddNeighbor(Neighbor newNeighbor)
        {
            int newId = Neighbors.Count > 0 ? Neighbors.Max(h => h.Id) + 1 : 1;
            newNeighbor.Id = newId;
            Neighbors.Add(newNeighbor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ViewNeighbor(int id)
        {
            var Neighbor = Neighbors.Find(h => h.Id == id);
            ViewBag.Neighbor = Neighbor;
            return View();
        }
    }
}
