using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Controllers
{
    [Area("Admin")]
    public class AdminDashboardController : Controller
    {
        private DBContext Context { get; set; }
        public AdminDashboardController(DBContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
        return View();
        }
    }
}
