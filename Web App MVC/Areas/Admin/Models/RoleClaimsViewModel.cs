using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

public class RoleClaimsViewModel
{
    public IdentityRole Role { get; set; }
    public List<IdentityUserClaim<string>> Claims { get; set; } = new List<IdentityUserClaim<string>>();
}
