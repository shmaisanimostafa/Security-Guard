using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Controllers
{
    public class ScanController : Controller
    {
        private DBContext Context { get; set; }
        public ScanController(DBContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Index(bool Completed) // to share alerts for success and failed scanning
        //{
        //    ViewBag.Completed = Completed;
        //    return View();
        //}
        public IActionResult Result()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(File file)
        {
            if (ModelState.IsValid)
            {
                List<File> files = Context.Files.ToList();
                file.FileName = "virus.pfd";
                file.Status = false;
                Context.Files.Add(file);
                Context.SaveChanges();
            }
            return RedirectToAction("Result");

        }
        public IActionResult Add(Link link)
        {
            if (ModelState.IsValid)
            {
                List<Link> Links = Context.Links.ToList();
                link.URL = "www.virus.pfd";
                link.Status = false;
                Context.Links.Add(link);
                Context.SaveChanges();
            }
            return RedirectToAction("Result");

        }
    }
}