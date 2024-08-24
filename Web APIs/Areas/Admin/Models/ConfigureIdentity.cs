using Microsoft.AspNetCore.Identity;
using Security_Guard.Models;
using Shared.Models;

namespace Security_Guard.Areas.Admin.Models
{
    public class ConfigureIdentity
    {
            public static async Task CreateAdminUserAsync(
            IServiceProvider provider)
            {
                var roleManager = provider
                .GetRequiredService<RoleManager<IdentityRole>>();
                var userManager =
                provider.GetRequiredService<UserManager<User>>();
                string username = "Shmaisanimostafa";
                string password = "123456";
                string roleName = "Admin";
            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(
                new IdentityRole(roleName));
            }
            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(
                user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(
                    user, roleName);
                }
            }
        }
    }
}
