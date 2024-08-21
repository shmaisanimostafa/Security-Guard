using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;

using Markdig;
using Microsoft.AspNetCore.Identity;

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
            IQueryable<Article> queryArticles = Context.Articles.OrderBy(n => n.Id);

            List<Article> Articles = queryArticles.ToList();
            ViewBag.Articles = Articles;
            return View();
        }


        [HttpGet]
        public IActionResult Index2()
        {
            // Query for all articles ordered by Id
            IQueryable<Article> queryArticles = Context.Articles.OrderBy(n => n.Id);
            List<Article> Articles = queryArticles.ToList();

            // Query for the first featured article
            Article featuredArticle = Context.Articles
                                              .Where(a => a.IsFeatured)
                                              .OrderBy(a => a.Id) // Ensure there's an order, or choose another property
                                              .FirstOrDefault();

            // Pass both lists to the view using ViewBag
            ViewBag.Articles = Articles;
            if (featuredArticle != null)
            {
                ViewBag.FeaturedArticle = featuredArticle;
            }

            return View();
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
            var articleToDelete = Context.Articles.OrderBy(f => f.Id).First(h => h.Id == id);

            if (articleToDelete != null)
            {
                Context.Articles.Remove(articleToDelete);
                Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult EditArticle(int id)
        {
            var articleToEdit = Context.Articles.OrderBy(f => f.Id).First(h => h.Id == id);
            if (articleToEdit != null)
            {

                ViewBag.Article = articleToEdit;
            }
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateArticle(Article updatedArticle)
        {
            var articleToUpdate = Context.Articles.OrderBy(f => f.Id).First(h => h.Id == updatedArticle.Id);
            articleToUpdate.Title = updatedArticle.Title;
            articleToUpdate.Content = updatedArticle.Content;
            articleToUpdate.Summary = updatedArticle.Summary;
            articleToUpdate.ImageURL = updatedArticle.ImageURL;
            articleToUpdate.SourceURL = updatedArticle.SourceURL;
            articleToUpdate.IsFeatured = updatedArticle.IsFeatured;
            Context.SaveChanges();
            return RedirectToAction("Index2");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddArticle(Article newArticle)
        {
            // int newId = Context.Articles.ToList().Count > 0 ? Context.Articles.Max(h => h.Id) + 1 : 1;
            // newArticle.Id = newId;
            Context.Articles.Add(newArticle);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ViewArticle(int id)
        {
            var Article = Context.Articles.First(h => h.Id == id);
            ViewBag.Article = Article;

            return View();
        }

        [HttpGet]
        public IActionResult ViewArticle2(int id)
        {
            // Get all articles
            IQueryable<Article> queryArticles = Context.Articles.OrderBy(n => n.Id);
            List<Article> Articles = queryArticles.Take(3).ToList();
            ViewBag.Articles = Articles;

            // Get the article with the specified id
            var Article = Context.Articles.First(h => h.Id == id);
            ViewBag.Article = Article;

            // Get the markdown content of the article with the specified id
            var htmlContent = ConvertMarkdownToHtml(Article.Content);
            ViewBag.HtmlContent = htmlContent;

            return View();
        }

        public string ConvertMarkdownToHtml(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder().Build();
            var html = Markdown.ToHtml(markdown, pipeline);
            return html;
        }

        [Authorize]
        public async Task<IActionResult> Subscribe()
        {
            var user = await _userManager.GetUserAsync(User);

            // Toggle the IsSubscribed property
            user.IsSubscribed = !user.IsSubscribed;

            // Update the user in the database
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                // Redirect to another action if the update was successful
                return RedirectToAction("Index2");
            }
            else
            {
                // Handle the case where the update fails
                // You might want to add some error handling here
                ModelState.AddModelError("", "Unable to update subscription status.");
                return View(); // or another appropriate view
            }
        }
    }
}
