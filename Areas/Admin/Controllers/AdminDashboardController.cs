
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdminDashboardController : Controller
    {
        private DBContext context;
        private DBContext Context { get => context; set => context = value; }
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
