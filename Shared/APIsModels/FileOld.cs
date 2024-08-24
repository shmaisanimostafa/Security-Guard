using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class FileOld
    {
        public int? Id { get; set; }
        [Required(ErrorMessage ="Please enter user name")]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string FileName { get; set; } = string.Empty;
        [Required(ErrorMessage = "The date must be filled")]
        public DateTime DateTime { get; set;} 

        public string Status = "danger";
        public string StatusMessage { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;

    }
}
