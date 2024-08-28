using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

public class RoleService : IRoleService
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleService(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<IdentityResult> CreateRoleAsync(string roleName)
    {
        var roleExists = await _roleManager.RoleExistsAsync(roleName);
        if (roleExists)
        {
            return IdentityResult.Failed(new IdentityError { Description = $"Role {roleName} already exists." });
        }
        var role = new IdentityRole(roleName);
        return await _roleManager.CreateAsync(role);
    }

    public async Task<IdentityResult> DeleteRoleAsync(string roleName)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        if (role == null)
        {
            return IdentityResult.Failed(new IdentityError { Description = $"Role {roleName} does not exist." });
        }
        return await _roleManager.DeleteAsync(role);
    }

    public async Task<IdentityResult> AddClaimToRoleAsync(string roleName, string claimType, string claimValue)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        if (role == null)
        {
            return IdentityResult.Failed(new IdentityError { Description = $"Role {roleName} does not exist." });
        }

        var claim = new Claim(claimType, claimValue);
        return await _roleManager.AddClaimAsync(role, claim);
    }

    public async Task<IdentityResult> RemoveClaimFromRoleAsync(string roleName, string claimType, string claimValue)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        if (role == null)
        {
            return IdentityResult.Failed(new IdentityError { Description = $"Role {roleName} does not exist." });
        }

        var claim = new Claim(claimType, claimValue);
        return await _roleManager.RemoveClaimAsync(role, claim);
    }
}
