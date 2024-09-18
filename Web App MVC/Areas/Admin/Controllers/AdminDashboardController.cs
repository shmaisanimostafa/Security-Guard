using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
//using Security_Guard.Models;
using Security_Guard.Areas.Admin.Models;
using File = Shared.Models.File;
using Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
//using Security_Guard.Data;

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
            // Get the list of users
            List<User> users = new List<User>();

            // Get the list of files
            IQueryable<File> queryFiles = context.Files.OrderBy(f => f.Id);

            List<File> Files = [.. queryFiles];

            // Get the list of links
            IQueryable<Link> queryLinks = context.Links.OrderBy(l => l.Id);

            List<Link> Links = [.. queryLinks];

            // Get the list of phishing emails
            IQueryable<PhishingEmail> queryEmails = context.PhishingEmails.OrderBy(l => l.Id);

            List<PhishingEmail> PhishingEmails = [.. queryEmails];

            foreach (User user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }

            // Combine all the data in one model to share them to the view
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
                Files = Files,
                PhishingEmails = PhishingEmails
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
        public async Task<IActionResult> DeleteEmail(int emailId)

        {

            // Debug Email Id
            Debug.WriteLine("EmailId is :");
            Debug.WriteLine(emailId);

            // Assuming you have a method to get the file by its ID
            PhishingEmail emailToDelete = await context.PhishingEmails.FindAsync(emailId);

            if (emailToDelete != null)
            {
                // Delete the file from the database
                context.PhishingEmails.Remove(emailToDelete);
                await context.SaveChangesAsync();

                TempData["message"] = "Email deleted successfully.";
                TempData["state"] = "danger";
            }
            else
            {
                TempData["message"] = "Email not found.";
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
        public IActionResult AddEmail()
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
        public async Task<IActionResult> AddEmail(PhishingEmail model, string userName)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName);

            // Create a new File instance
            PhishingEmail newEmail = new PhishingEmail
            {
                UserName = model.UserName,
                User = user,
                EmailMessage = model.EmailMessage,
                PredictedClass = model.PredictedClass,
                ConfidenceScore = model.ConfidenceScore,
                DateTime = DateTime.UtcNow,
                IPAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),
                ModelVersion = "v1.0",
                UserFeedback = model.UserFeedback,
                ReClassification = null

            };

            // Validate the model
            if (ModelState.IsValid)
            {
                // Add the new file to the database
                context.PhishingEmails.Add(newEmail);
                await context.SaveChangesAsync();

                return RedirectToAction("Result");

            }
            else
            {
                return View(newEmail);
            }
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