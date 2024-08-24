using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class LinkOld
    {
        [Required] 
        public int? Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "URL is required.")]
        public string URL { get; set; } = string.Empty;
        [Required]
        public string Status { get; set; } = "safe";
        public string StatusMessage { get; set; } = string.Empty;
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
