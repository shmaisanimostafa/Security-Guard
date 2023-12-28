using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class Link
    {
        [Required] 
        public int? Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string URL { get; set; } = string.Empty;
        [Required]
        public bool Status { get; set; } = false;
        [Required]
        public string StatusMessage { get; set; } = string.Empty;
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
