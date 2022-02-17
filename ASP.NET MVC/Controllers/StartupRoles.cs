using Microsoft.AspNetCore.Identity;
using ASP.NET_MVC.Models.Identity;

namespace ASP.NET_MVC.Controllers
{
    public class StartupRoles
    {
        private static readonly string[] Roles = new string[] { "Admin", "User" };
        private static UserManager<AppUser> _userManager;
        public static async Task SeedRoles(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();
                foreach (var role in Roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        await roleManager.CreateAsync(new AppRole(role));
                    }
                }
                var user = new AppUser { UserName = "admin" };
                _userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var result = await _userManager.CreateAsync(user, "admin");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
