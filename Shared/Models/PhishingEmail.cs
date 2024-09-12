using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class PhishingEmail
    {
        [Key]
        public int Id { get; set; } // Assuming Id is auto-incrementing and not nullable.

        [Required]
        [StringLength(256)] // Adjust the length as needed
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Message is required.")]
        public string EmailMessage { get; set; } = string.Empty;

        [Required]
        public int PredictedClass { get; set; }

        public float ConfidenceScore { get; set; }

        [Required]
        public DateTime DateTime { get; set; } = DateTime.UtcNow; // Using UTC time

        public User? User { get; set; }

        public string? IPAddress { get; set; }

        public string? ModelVersion { get; set; }

        public string? UserFeedback { get; set; }

        public bool? ReClassification { get; set; }
    }
}
