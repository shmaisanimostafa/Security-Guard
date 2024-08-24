namespace Shared.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Author { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation property
        public Article Article { get; set; }
    }
}
