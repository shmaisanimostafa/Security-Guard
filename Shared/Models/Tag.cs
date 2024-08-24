//using Security_Guard.Models;
//using System.Collections.Generic;

using Shared.Models;

namespace Shared.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public ICollection<ArticleTag> ArticleTags { get; set; } = new List<ArticleTag>();
    }

}