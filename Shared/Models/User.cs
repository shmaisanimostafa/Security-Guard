using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;

namespace Shared.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public bool IsSubscribed { get; set; } = false;

        [NotMapped]
        public IList<string>? RoleNames { get; set; }  // Use for display purposes only
    }
}
