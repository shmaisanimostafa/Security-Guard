using Microsoft.AspNetCore.Mvc;

namespace Security_Guard.Controllers
{
    public class ScanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
