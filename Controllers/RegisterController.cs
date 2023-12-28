using Microsoft.AspNetCore.Mvc;

namespace Security_Guard.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
