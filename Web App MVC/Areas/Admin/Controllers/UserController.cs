using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Security_Guard.Models;
using Security_Guard.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Security_Guard.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
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

        public async Task<IActionResult> Index()
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

            ViewData["RoleManagementModel"] = new RoleManagementViewModel
            {
                RolesWithClaims = roleClaims
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(string userId, string roleName)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await userManager.AddToRoleAsync(user, roleName);
                if (!result.Succeeded)
                {
                    TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveRoleFromUser(string userId, string roleName)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await userManager.RemoveFromRoleAsync(user, roleName);
                if (!result.Succeeded)
                {
                    TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            var result = await roleService.CreateRoleAsync("Admin");
            if (!result.Succeeded)
            {
                TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            if (role != null)
            {
                var result = await roleManager.DeleteAsync(role);
                if (!result.Succeeded)
                {
                    TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
                }
            }
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

            var result = await roleService.AddClaimToRoleAsync(roleName, claimType, claimValue);
            if (!result.Succeeded)
            {
                TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
            }
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

            var result = await roleService.RemoveClaimFromRoleAsync(roleName, claimType, claimValue);
            if (!result.Succeeded)
            {
                TempData["message"] = string.Join(" | ", result.Errors.Select(e => e.Description));
            }
            return RedirectToAction("Index");
        }
    }
}
