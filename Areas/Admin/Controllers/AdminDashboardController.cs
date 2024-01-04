using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using Security_Guard.Areas.Admin.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdminDashboardController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;
        private DBContext context;

        public AdminDashboardController(UserManager<User> userMngr,
                                        RoleManager<IdentityRole> roleMngr,
                                        DBContext ctx)
        {
            userManager = userMngr;
            roleManager = roleMngr;
            context = ctx;
        }

        public async Task<IActionResult> Index()
        {
            List<User> users = new List<User>();

            IQueryable<File> queryFiles = context.Files.OrderBy(f => f.Id);

            List<File> Files = [.. queryFiles];

            IQueryable<Link> queryLinks = context.Links.OrderBy(l => l.Id);

            List<Link> Links = [.. queryLinks];

            foreach (User user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }

            FullData model = new FullData
            {
                UserViews = new List<UserViewModel>
                {
                    new UserViewModel
                    {
                        Users = users,
                        Roles = roleManager.Roles
                    }
                },
                Links = Links,
                Files = Files
             };

            return View(model);
        }
    }
}