using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Security_Guard.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [NotMapped]
        public IList<string>? RoleNames { get; set; }

        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword {  get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public string ImgURL { get; set; } = string.Empty;

    }
}
