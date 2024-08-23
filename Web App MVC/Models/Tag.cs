using System.Collections.Generic;

namespace Security_Guard.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public ICollection<ArticleTag> ArticleTags { get; set; } = new List<ArticleTag>();
    }
}
