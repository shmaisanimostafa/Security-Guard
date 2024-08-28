using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Security_Guard.Areas.Admin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiRoleClaimController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRoleService _roleService;

        public ApiRoleClaimController(RoleManager<IdentityRole> roleManager, IRoleService roleService)
        {
            _roleManager = roleManager;
            _roleService = roleService;
        }

        [HttpGet("roles")]
        public async Task<IActionResult> GetRolesWithClaims()
        {
            var roles = _roleManager.Roles.ToList();
            var roleClaims = new List<RoleClaimsViewModel>();

            foreach (var role in roles)
            {
                var claims = await _roleManager.GetClaimsAsync(role);
                roleClaims.Add(new RoleClaimsViewModel
                {
                    Role = role,
                    Claims = claims.Select(c => new IdentityUserClaim<string> { ClaimType = c.Type, ClaimValue = c.Value }).ToList()
                });
            }

            var model = new RoleManagementViewModel
            {
                RolesWithClaims = roleClaims
            };

            return Ok(model);
        }

        [HttpPost("roles")]
        public async Task<IActionResult> CreateRole([FromBody] string newRoleName)
        {
            if (string.IsNullOrWhiteSpace(newRoleName))
            {
                return BadRequest("Role name is required.");
            }

            var result = await _roleService.CreateRoleAsync(newRoleName);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors.First().Description);
        }

        [HttpDelete("roles/{roleName}")]
        public async Task<IActionResult> DeleteRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                return BadRequest("Role name is required.");
            }

            var result = await _roleService.DeleteRoleAsync(roleName);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors.First().Description);
        }

        [HttpPost("roles/{roleName}/claims")]
        public async Task<IActionResult> AddClaimToRole(string roleName, [FromBody] ClaimDto claimDto)
        {
            if (string.IsNullOrWhiteSpace(roleName) || claimDto == null || string.IsNullOrWhiteSpace(claimDto.ClaimType) || string.IsNullOrWhiteSpace(claimDto.ClaimValue))
            {
                return BadRequest("Role name, claim type, and claim value are required.");
            }

            var result = await _roleService.AddClaimToRoleAsync(roleName, claimDto.ClaimType, claimDto.ClaimValue);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors.First().Description);
        }

        [HttpDelete("roles/{roleName}/claims")]
        public async Task<IActionResult> RemoveClaimFromRole(string roleName, [FromBody] ClaimDto claimDto)
        {
            if (string.IsNullOrWhiteSpace(roleName) || claimDto == null || string.IsNullOrWhiteSpace(claimDto.ClaimType) || string.IsNullOrWhiteSpace(claimDto.ClaimValue))
            {
                return BadRequest("Role name, claim type, and claim value are required.");
            }

            var result = await _roleService.RemoveClaimFromRoleAsync(roleName, claimDto.ClaimType, claimDto.ClaimValue);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors.First().Description);
        }
    }

    public class ClaimDto
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
