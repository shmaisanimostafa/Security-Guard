using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

public class RoleManagementViewModel
{
    public List<RoleClaimsViewModel> RolesWithClaims { get; set; } = new List<RoleClaimsViewModel>();
}
