using Microsoft.AspNetCore.Identity;

namespace Security_Guard.Models
{
    public class AdminSeedService : IHostedService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminSeedService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // Create roles
            string[] roleNames = { "Admin", "User" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Create the admin user
            var adminUser = new IdentityUser
            {
                UserName = "Shmaisanimostafa",
                Email = "Shmaisanimostafa@gmail.com",
            };

            string adminPassword = "Admin@123"; // Set a secure password
            var user = await _userManager.FindByEmailAsync(adminUser.Email);

            if (user == null)
            {
                var createAdmin = await _userManager.CreateAsync(adminUser, adminPassword);
                if (createAdmin.Succeeded)
                {
                    await _userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }

}
