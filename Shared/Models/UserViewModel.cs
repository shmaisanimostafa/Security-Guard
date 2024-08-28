using Microsoft.AspNetCore.Identity;
using Shared.Models;

//using Security_Guard.Models;
using System.Collections.Generic;


public class UserViewModel
{
    public IEnumerable<User> Users { get; set; }
    public IEnumerable<IdentityRole> Roles { get; set; }
    public RoleManagementViewModel RolesWithClaims { get; set; } // Add this line

}

