using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Models;


namespace Security_Guard.Areas.Admin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IRoleService roleService;

        public UserController(UserManager<User> userMngr, RoleManager<IdentityRole> roleMngr, IRoleService roleSvc)
        {
            userManager = userMngr;
            roleManager = roleMngr;
            roleService = roleSvc;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
            }

            var roles = await roleManager.Roles.ToListAsync();
            var roleClaims = new List<RoleClaimsViewModel>();

            foreach (var role in roles)
            {
                var claims = await roleManager.GetClaimsAsync(role);
                roleClaims.Add(new RoleClaimsViewModel
                {
                    Role = role,
                    Claims = claims.Select(c => new IdentityUserClaim<string> { ClaimType = c.Type, ClaimValue = c.Value }).ToList()
                });
            }

            var model = new UserViewModel
            {
                Users = users,
                Roles = roles
            };

            return Ok(new
            {
                Users = model.Users,
                Roles = model.Roles,
                RoleManagementModel = new RoleManagementViewModel
                {
                    RolesWithClaims = roleClaims
                }
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            var result = await userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return NoContent(); // Status code 204 for successful deletion
        }

        [HttpPost("AddRoleToUser")]
        public async Task<IActionResult> AddRoleToUser([FromBody] AddRoleRequest request)
        {
            var user = await userManager.FindByIdAsync(request.UserId);
            if (user == null)
            {
                return NotFound($"User with ID {request.UserId} not found.");
            }

            var result = await userManager.AddToRoleAsync(user, request.RoleName);
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return Ok(); // Status code 200 for successful role addition
        }

        [HttpPost("RemoveRoleFromUser")]
        public async Task<IActionResult> RemoveRoleFromUser([FromBody] RemoveRoleRequest request)
        {
            var user = await userManager.FindByIdAsync(request.UserId);
            if (user == null)
            {
                return NotFound($"User with ID {request.UserId} not found.");
            }

            var result = await userManager.RemoveFromRoleAsync(user, request.RoleName);
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return Ok(); // Status code 200 for successful role removal
        }

        [HttpPost("CreateAdminRole")]
        public async Task<IActionResult> CreateAdminRole()
        {
            var result = await roleService.CreateRoleAsync("Admin");
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return Ok(); // Status code 200 for successful role creation
        }

        [HttpDelete("DeleteRole/{roleId}")]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                return NotFound($"Role with ID {roleId} not found.");
            }

            var result = await roleManager.DeleteAsync(role);
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return NoContent(); // Status code 204 for successful role deletion
        }

        [HttpPost("AddClaimToRole")]
        public async Task<IActionResult> AddClaimToRole([FromBody] AddClaimRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.RoleName) || string.IsNullOrWhiteSpace(request.ClaimType) || string.IsNullOrWhiteSpace(request.ClaimValue))
            {
                return BadRequest("Role name, claim type, and claim value are required.");
            }

            var result = await roleService.AddClaimToRoleAsync(request.RoleName, request.ClaimType, request.ClaimValue);
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return Ok(); // Status code 200 for successful claim addition
        }

        [HttpPost("RemoveClaimFromRole")]
        public async Task<IActionResult> RemoveClaimFromRole([FromBody] RemoveClaimRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.RoleName) || string.IsNullOrWhiteSpace(request.ClaimType) || string.IsNullOrWhiteSpace(request.ClaimValue))
            {
                return BadRequest("Role name, claim type, and claim value are required.");
            }

            var result = await roleService.RemoveClaimFromRoleAsync(request.RoleName, request.ClaimType, request.ClaimValue);
            if (!result.Succeeded)
            {
                return BadRequest(new { Errors = result.Errors.Select(e => e.Description) });
            }

            return Ok(); // Status code 200 for successful claim removal
        }

        public class AddRoleRequest
        {
            public string UserId { get; set; }
            public string RoleName { get; set; }
        }

        public class RemoveRoleRequest
        {
            public string UserId { get; set; }
            public string RoleName { get; set; }
        }

        public class AddClaimRequest
        {
            public string RoleName { get; set; }
            public string ClaimType { get; set; }
            public string ClaimValue { get; set; }
        }

        public class RemoveClaimRequest
        {
            public string RoleName { get; set; }
            public string ClaimType { get; set; }
            public string ClaimValue { get; set; }
        }
    }
}
