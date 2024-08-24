using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{

    public class Article
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int ReadCount { get; set; }
        public int LikeCount { get; set; }
        public int DisLikeCount { get; set; }
        public string Content { get; set; } = "";
        public string Summary { get; set; } = "A brief summary of the article";
        public bool IsFeatured { get; set; } = false;
        public string SourceURL { get; set; } = "";
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string ImageURL { get; set; } = "";
        public DateTime PublishDate { get; set; } = DateTime.Now;

        // Navigation properties
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<ArticleTag> ArticleTags { get; set; } = new List<ArticleTag>();
    }
}
