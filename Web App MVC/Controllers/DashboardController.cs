using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

//using Security_Guard.Data;
//using Security_Guard.Models;
using File = Shared.Models.File;

namespace Security_Guard.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private DBContext Context { get; set; }
        public DashboardController(DBContext ctx)
        {
            Context = ctx;
        }


        public IActionResult Index()
        {
            IQueryable<File> queryFiles = Context.Files.OrderBy(f => f.Id);

            List<File> Files = [.. queryFiles];

            IQueryable<Link> queryLinks = Context.Links.OrderBy(l => l.Id);

            List<Link> Links = [.. queryLinks];


            FileLink fileLink = new FileLink
            {
                files = Files,
                links = Links
            };

            return View(fileLink);
        }
    }
}
