using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Controllers
{
    public class DashboardController : Controller
    {
        private DBContext Context { get; set; }
        public DashboardController(DBContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            IQueryable<File> query = Context.Files.OrderBy(f => f.Id);

            List<File> Files = query.ToList();
            
            return View(Files);
        }
    }
}
