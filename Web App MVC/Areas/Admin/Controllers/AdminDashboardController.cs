using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;
using Security_Guard.Areas.Admin.Models;
using File = Security_Guard.Models.File;

namespace Security_Guard.Controllers
{
    // [Authorize(Roles = "Admin")]
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
        public async Task<IActionResult> Index2()
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
        [HttpPost]
        public async Task<IActionResult> DeleteFile(int fileId)
        {
            // Assuming you have a method to get the file by its ID
            File fileToDelete = await context.Files.FindAsync(fileId);

            if (fileToDelete != null)
            {
                // Delete the file from the database
                context.Files.Remove(fileToDelete);
                await context.SaveChangesAsync();

                TempData["message"] = "File deleted successfully.";
                TempData["state"] = "danger";
            }
            else
            {
                TempData["message"] = "File not found.";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLink(int linkId)
        {
            // Assuming you have a method to get the file by its ID
            Link linkToDelete = await context.Links.FindAsync(linkId);

            if (linkToDelete != null)
            {
                // Delete the file from the database
                context.Links.Remove(linkToDelete);
                await context.SaveChangesAsync();

                TempData["message"] = "Link deleted successfully.";
                TempData["state"] = "danger";
            }
            else
            {
                TempData["message"] = "Link not found.";
            }

            return RedirectToAction("Index");
        }

        public IActionResult AddLink()
        {
            return View();
        }
        public IActionResult AddFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddLink(string url, string status, string statusMessage)
        {
            // Get the username of the currently signed-in user
            string userName = User.Identity.Name;

            // Create a new Link instance
            Link newLink = new Link
            {
                UserName = userName,
                DateTime = DateTime.Now,
                Status = status,
                StatusMessage = statusMessage,
                URL = url
            };

            // Validate the model
            if (ModelState.IsValid)
            {
                // Add the new link to the database
                context.Links.Add(newLink);
                await context.SaveChangesAsync();

                TempData["message"] = "Link added successfully.";
                TempData["state"] = "success";

                return RedirectToAction("Index");
            }

            // If the model state is not valid, return to the form with validation errors
            return View(newLink);
        }


        [HttpPost]
        public async Task<IActionResult> AddFile(string fileName, string url, string status, string statusMessage)
        {
            // Get the username of the currently signed-in user
            string userName = User.Identity.Name;

            // Create a new File instance
            File newFile = new File
            {
                UserName = userName,
                DateTime = DateTime.Now,
                Status = status,
                StatusMessage = statusMessage,
                URL = url,
                FileName = fileName
            };

            // Validate the model
            if (ModelState.IsValid)
            {
                // Add the new file to the database
                context.Files.Add(newFile);
                await context.SaveChangesAsync();

                TempData["message"] = "File added successfully.";
                TempData["state"] = "success";

                return RedirectToAction("Index");
            }

            // If the model state is not valid, return to the form with validation errors
            return View(newFile);
        }

    }
}