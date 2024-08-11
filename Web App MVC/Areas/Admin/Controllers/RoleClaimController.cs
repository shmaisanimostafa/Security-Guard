using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Security_Guard.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoleClaimController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRoleService _roleService;

        public RoleClaimController(RoleManager<IdentityRole> roleManager, IRoleService roleService)
        {
            _roleManager = roleManager;
            _roleService = roleService;
        }

        public async Task<IActionResult> Index()
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

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(string newRoleName)
        {
            if (string.IsNullOrWhiteSpace(newRoleName))
            {
                ModelState.AddModelError("", "Role name is required.");
                return RedirectToAction("Index");
            }

            var result = await _roleService.CreateRoleAsync(newRoleName);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Errors.First().Description);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                ModelState.AddModelError("", "Role name is required.");
                return RedirectToAction("Index");
            }

            var result = await _roleService.DeleteRoleAsync(roleName);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Errors.First().Description);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddClaimToRole(string roleName, string claimType, string claimValue)
        {
            if (string.IsNullOrWhiteSpace(roleName) || string.IsNullOrWhiteSpace(claimType) || string.IsNullOrWhiteSpace(claimValue))
            {
                ModelState.AddModelError("", "Role name, claim type, and claim value are required.");
                return RedirectToAction("Index");
            }

            var result = await _roleService.AddClaimToRoleAsync(roleName, claimType, claimValue);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Errors.First().Description);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveClaimFromRole(string roleName, string claimType, string claimValue)
        {
            if (string.IsNullOrWhiteSpace(roleName) || string.IsNullOrWhiteSpace(claimType) || string.IsNullOrWhiteSpace(claimValue))
            {
                ModelState.AddModelError("", "Role name, claim type, and claim value are required.");
                return RedirectToAction("Index");
            }

            var result = await _roleService.RemoveClaimFromRoleAsync(roleName, claimType, claimValue);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Errors.First().Description);
            return RedirectToAction("Index");
        }
    }
}