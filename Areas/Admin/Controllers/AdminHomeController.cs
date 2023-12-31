using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using System.Diagnostics;
using System.Linq;

namespace Security_Guard.Controllers
{
    [Area("Admin")]
    public class AdminHomeController : Controller
    {
        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

    }
}
