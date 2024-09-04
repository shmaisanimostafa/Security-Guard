using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using Security_Guard.Models;
using Markdig;
using Microsoft.AspNetCore.Identity;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Collections.Generic;
using Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Security_Guard.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly UserManager<User> _userManager;
        private DBContext Context { get; set; }

        public ArticlesController(DBContext ctx, UserManager<User> userManager)
        {
            Context = ctx;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var articles = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag) // Include tags
                .OrderBy(n => n.Id)
                .ToList();

            ViewBag.Articles = articles;
            return View();
        }



        [HttpGet]
        public IActionResult Index2()
        {
            var articles = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag) // Include tags
                .OrderBy(n => n.Id)
                .ToList();

            var tags = Context.Tags.ToList(); // Fetch all tags for navigation bar

            var featuredArticle = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag)
                .Where(a => a.IsFeatured)
                .OrderBy(a => a.Id)
                .FirstOrDefault();

            ViewBag.Tags = tags;
            ViewBag.Articles = articles;
            ViewBag.FeaturedArticle = featuredArticle;
            ViewBag.currentTagId = null;

            return View();
        }
        [HttpGet]
        public IActionResult Index3(int tagId)
        {


            var tags = Context.Tags.ToList(); // Fetch all tags for navigation bar

            var featuredArticle = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag)
                .Where(a => a.IsFeatured)
                .OrderBy(a => a.Id)
                .FirstOrDefault();

            var articles = Context.Articles
                           .Include(a => a.ArticleTags)
                           .ThenInclude(at => at.Tag)
                           .Where(a => a.ArticleTags.Any(at => at.TagId == tagId))
                           .OrderBy(a => a.Id)
                           .ToList();


            ViewBag.Articles = articles;
            ViewBag.Tags = tags;
            ViewBag.CurrentTagId = tagId;

            ViewBag.FeaturedArticle = featuredArticle;

            return View("Index2");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddArticle()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var articleToDelete = Context.Articles
                .Include(a => a.ArticleTags) // Include tags
                .FirstOrDefault(h => h.Id == id);

            if (articleToDelete != null)
            {
                Context.Articles.Remove(articleToDelete);
                Context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult EditArticle(int id)
        {
            var articleToEdit = Context.Articles
                .Include(a => a.ArticleTags) // Include tags
                .ThenInclude(at => at.Tag)
                .FirstOrDefault(h => h.Id == id);

            if (articleToEdit != null)
            {
                ViewBag.Article = articleToEdit;
            }

            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult UpdateArticle(Article updatedArticle)
        {
            var articleToUpdate = Context.Articles
                .Include(a => a.ArticleTags) // Include tags
                .ThenInclude(at => at.Tag)
                .FirstOrDefault(h => h.Id == updatedArticle.Id);

            if (articleToUpdate != null)
            {
                articleToUpdate.Title = updatedArticle.Title;
                articleToUpdate.Content = updatedArticle.Content;
                articleToUpdate.Summary = updatedArticle.Summary;
                articleToUpdate.ImageURL = updatedArticle.ImageURL;
                articleToUpdate.SourceURL = updatedArticle.SourceURL;
                articleToUpdate.IsFeatured = updatedArticle.IsFeatured;

                // Update tags if needed
                // Context.SaveChanges();
            }

            Context.SaveChanges();
            return RedirectToAction("Index2");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddArticle(Article newArticle)
        {
            Context.Articles.Add(newArticle);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ViewArticle(int id)
        {
            var article = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag) // Include tags
                .FirstOrDefault(h => h.Id == id);

            ViewBag.Article = article;
            return View();
        }

        [HttpGet]
        public IActionResult ViewArticle2(int id)
        {
            var articles = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag) // Include tags
                .OrderBy(n => n.Id)
                .Take(3)
                .ToList();

            var article = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag) // Include tags
                .FirstOrDefault(h => h.Id == id);

            var htmlContent = ConvertMarkdownToHtml(article?.Content);

            ViewBag.Articles = articles;
            ViewBag.Article = article;
            ViewBag.HtmlContent = htmlContent;

            return View();
        }

        public string ConvertMarkdownToHtml(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder().Build();
            var html = Markdown.ToHtml(markdown, pipeline);
            return html;
        }


        [HttpPost]
        public async Task<IActionResult> Subscribe()
        {
            var user = await _userManager.GetUserAsync(User);


            // Toggle the IsSubscribed property
            user.IsSubscribed = !user.IsSubscribed;

            // Update the user in the database
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index2");
            }
            else
            {
                ModelState.AddModelError("", "Unable to update subscription status.");
                return View(); // or another appropriate view
            }
        }

        //public IActionResult FilterByTag(int tagId)
        //{
        //    var articles = Context.Articles
        //        .Include(a => a.ArticleTags)
        //        .ThenInclude(at => at.Tag)
        //        .Where(a => a.ArticleTags.Any(at => at.TagId == tagId))
        //        .OrderBy(a => a.Id)
        //        .ToList();

        //    var tags = Context.Tags.ToList(); // Fetch all tags for navigation bar

        //    ViewBag.Articles = articles;
        //    ViewBag.Tags = tags;
        //    ViewBag.CurrentTagId = tagId;

        //    return View("Index"); // Ensure this view has the updated logic to display the filtered articles
        //}
        public IActionResult FilterByTag(int tagId)
        {
            var articles = Context.Articles
                .Include(a => a.ArticleTags)
                .ThenInclude(at => at.Tag)
                .Where(a => a.ArticleTags.Any(at => at.TagId == tagId))
                .OrderBy(a => a.Id)
                .ToList();

            var tags = Context.Tags.ToList(); // Fetch all tags for navigation bar

            ViewBag.Articles = articles;
            ViewBag.Tags = tags;
            ViewBag.CurrentTagId = tagId;

            return View("FilterByTag"); // Use the new FilterByTag view
        }


    }
}
