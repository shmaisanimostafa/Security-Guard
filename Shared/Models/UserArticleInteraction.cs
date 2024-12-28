
namespace Shared.Models
{
    public class UserArticleInteraction
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public string Interaction { get; set; }  // Can be "Like", "Dislike", or "Neutral"
    }

}
