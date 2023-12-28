using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models
{
    public class File
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string FileName { get; set; } = string.Empty;
        [Required]
        public DateTime DateTime { get; set;} = DateTime.Now;
        [Required]
        public bool Status = false;
        [Required]
        public string StatusMessage { get; set; } = string.Empty;
        [Required]
        public string URL { get; set; } = string.Empty;


    }
}
