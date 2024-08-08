using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security_Guard.Models;

namespace Security_Guard.Controllers
{
    public class ArticlesController : Controller
    {
        private DBContext Context { get; set; }
        public ArticlesController(DBContext ctx)
        {
            Context = ctx;
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
            IQueryable<Article> queryArticles = Context.Articles.OrderBy(n => n.Id);

            List<Article> Articles = queryArticles.ToList();
            ViewBag.Articles = Articles;
            return View();
        }
        [Authorize(Roles ="Admin")]
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
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddArticle(Article newArticle)
        {
            int newId = Context.Articles.ToList().Count > 0 ? Context.Articles.Max(h => h.Id) + 1 : 1;
            newArticle.Id = newId;
            Context.Articles.Add(newArticle);
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
            return View();
        }
    }
}
