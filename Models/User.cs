using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Security_Guard.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [NotMapped]
        public IList<string>? RoleNames { get; set; }
        [Required]
        public string Name { get; set; } =string.Empty;
 
        public string ConfirmEmail { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword {  get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty;

        public string ImgURL { get; set; } = string.Empty;

    }
}
