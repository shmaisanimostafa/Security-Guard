using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class Report
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public int? ScanId { get; set; }
        [Required] 
        public string UserName { get; set; } =String.Empty;
        [Required]
        public required string Description { get; set; }
        [Required]
        public int? ThreatLevel { get; set; }
    }
}
