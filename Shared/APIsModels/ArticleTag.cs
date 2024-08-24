namespace Security_Guard.Models
{
    public class ArticleTag
    {
        public int ArticleId { get; set; }
        public ArticleOld Article { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
