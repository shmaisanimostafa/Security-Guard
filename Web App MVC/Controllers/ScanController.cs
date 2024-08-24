//using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

//using Security_Guard.Data;
//using Security_Guard.Models;
using File = Shared.Models.File;

namespace Security_Guard.Controllers
{
    public class ScanController : Controller
    {
        private DBContext Context { get; set; }
        public ScanController(DBContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddLink(string userName,string url, string status, string statusMessage)
        {
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
                Context.Links.Add(newLink);
                await Context.SaveChangesAsync();

                return RedirectToAction("Result");
            }

            // If the model state is not valid, return to the form with validation errors
            return View("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(File model)
        {

            // Create a new File instance
            File newFile = new File
            {
                UserName = model.UserName,
                DateTime = DateTime.Now,
                Status = model.Status,
                StatusMessage = model.StatusMessage,
                URL = model.URL,
                FileName = model.FileName
            };

            // Validate the model
            if (ModelState.IsValid)
            {
                // Add the new file to the database
                Context.Files.Add(newFile);
                await Context.SaveChangesAsync();

                return RedirectToAction("Result");
                
            }
            else
            {
                return View("Index");
            }
        }
    }
}