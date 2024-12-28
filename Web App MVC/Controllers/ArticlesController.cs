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
        // Action to handle comment submission
        [HttpPost]
        public IActionResult AddComment(int articleId, string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                ModelState.AddModelError("Content", "Comment cannot be empty.");
                return RedirectToAction("ViewArticle2", new { id = articleId });
            }

            var article = Context.Articles.FirstOrDefault(a => a.Id == articleId);
            if (article == null)
            {
                return NotFound();
            }

            // Get current user (assuming you have user management set up)
            var currentUser = _userManager.GetUserAsync(User).Result;

            // Create the comment
            var comment = new Comment
            {
                ArticleId = articleId,
                Author = currentUser?.UserName ?? "Anonymous", // Default to Anonymous if no user is logged in
                Content = content,
                CreatedDate = DateTime.Now
            };

            // Add the comment to the database
            Context.Comments.Add(comment);
            Context.SaveChanges();

            // Redirect back to the article view with the updated comments
            return RedirectToAction("ViewArticle2", new { id = articleId });
        }
        // GET: Edit Comment
        [HttpGet]
        public IActionResult EditComment(int id)
        {
            var comment = Context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment); // Pass the comment to the Edit view
        }

        // POST: Edit Comment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditComment(int id, string content)
        {
            var comment = Context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            // Update the comment content
            comment.Content = content;
            Context.SaveChanges(); // Save changes to the database

            return RedirectToAction("ViewArticle2", new { id = comment.ArticleId }); // Redirect to the article page
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteComment(int id)
        {
            var comment = Context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            Context.Comments.Remove(comment); // Remove the comment
            Context.SaveChanges(); // Save changes to the database

            return RedirectToAction("ViewArticle2", new { id = comment.ArticleId }); // Redirect to the article page
        }


        [HttpGet]
        public IActionResult ViewArticle2(int id)
        {
            // Get the article with its associated comments
            var article = Context.Articles
                .Include(a => a.Comments) // Include comments
                .Include(a => a.ArticleTags)
                    .ThenInclude(at => at.Tag)
                .FirstOrDefault(h => h.Id == id);

            if (article == null) return NotFound();

            var user = _userManager.GetUserAsync(User).Result;
            var userInteraction = Context.UserArticleInteractions
                .FirstOrDefault(ua => ua.UserId.ToString() == user.Id && ua.ArticleId == id);

            // Process article content (e.g., convert markdown to HTML)
            var htmlContent = ConvertMarkdownToHtml(article.Content);

            // Count likes and dislikes
            var likesCount = Context.UserArticleInteractions.Count(ua => ua.ArticleId == id && ua.Interaction == "Like");
            var dislikesCount = Context.UserArticleInteractions.Count(ua => ua.ArticleId == id && ua.Interaction == "Dislike");

            // Pass data to the view
            ViewBag.LikesCount = likesCount;
            ViewBag.DislikesCount = dislikesCount;
            ViewBag.UserInteraction = userInteraction?.Interaction ?? "Neutral";
            ViewBag.Articles = Context.Articles.Take(3).ToList(); // Recent articles

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

        [HttpPost]
        public async Task<IActionResult> ToggleLikeDislike(int articleId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();  // Ensure the user is logged in

            var article = await Context.Articles.FirstOrDefaultAsync(a => a.Id == articleId);
            if (article == null) return NotFound();  // Ensure the article exists

            // Track the user's previous interaction
            var userInteraction = await Context.UserArticleInteractions
                .FirstOrDefaultAsync(ua => ua.UserId.ToString() == user.Id && ua.ArticleId == articleId);

            if (userInteraction != null)
            {
                // If the user interacted before, toggle their interaction
                if (userInteraction.Interaction == "Like")
                {
                    article.LikeCount--;  // Decrease the like count
                    article.DisLikeCount++;  // Increase the dislike count
                    userInteraction.Interaction = "Dislike";  // Change to dislike
                }
                else if (userInteraction.Interaction == "Dislike")
                {
                    article.DisLikeCount--;  // Decrease the dislike count
                    article.LikeCount++;  // Increase the like count
                    userInteraction.Interaction = "Like";  // Change to like
                }
                else
                {
                    // Neutral, so change to like
                    article.LikeCount++;  // Increase like count
                    userInteraction.Interaction = "Like";  // Change to like
                }
            }
            else
            {
                // If the user has not interacted, initialize with "like"
                article.LikeCount++;
                Context.UserArticleInteractions.Add(new UserArticleInteraction
                {
                    UserId = user.Id,
                    ArticleId = articleId,
                    Interaction = "Like"
                });
            }

            await Context.SaveChangesAsync();

            return RedirectToAction("ViewArticle2", new { id = articleId });
        }



    }
}
