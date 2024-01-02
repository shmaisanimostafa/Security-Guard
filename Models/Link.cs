using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class Link
    {
        [Required] 
        public int? Id { get; set; }
        [Required]
        [StringLength(20)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string URL { get; set; } = string.Empty;
        [Required]
        public String Status { get; set; } = "safe";
        public string StatusMessage { get; set; } = string.Empty;
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
