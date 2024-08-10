using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int Rating { get; set; }

        // For categories and tags
        public List<string> Tags { get; set; } = [];

        public int ReadCount { get; set; }
        public int LikeCount { get; set; }
        public int DisLikeCount { get; set; }
        public string Content { get; set; } = "";
        public string Summary { get; set; } = "A brief summary on the article";
        // Indicates whether an article is featured or not to be displayed on top
        public bool IsFeatured { get; set; } = false;
        public string SourceURL { get; set; } = "";
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string ImageURL { get; set; } = "";

        public DateTime PublishDate { get; set; } = DateTime.Now;


        // Add Array of comments, with Comment Model
        // public List<Comment> Comments {get; set; }

        // Add Array of Keywords
        // Add Status whether the article is published, draft, or archieved
        // Add SEO Title
        // Add SEO Description
    }
}
