using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; } = "";
        public string Body2 { get; set; } = "Say Something as Body2";
        public string URL { get; set; } = "";
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string ImageURL { get; set; } = "";
    }
}
