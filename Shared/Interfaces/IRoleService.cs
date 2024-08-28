using Microsoft.AspNetCore.Identity;

public interface IRoleService
{
    Task<IdentityResult> CreateRoleAsync(string roleName);
    Task<IdentityResult> DeleteRoleAsync(string roleName);
    Task<IdentityResult> AddClaimToRoleAsync(string roleName, string claimType, string claimValue);
    Task<IdentityResult> RemoveClaimFromRoleAsync(string roleName, string claimType, string claimValue);
}
