using Microsoft.AspNetCore.Identity;
using System.Collections.Generic; // Make sure this is included for the list
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public bool IsSubscribed { get; set; } = false;
        public bool IsVerified { get; set; } = false;

        [NotMapped]
        public IList<string>? RoleNames { get; set; }  // Use for display purposes only

        // Navigation property for Articles written by this User
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
