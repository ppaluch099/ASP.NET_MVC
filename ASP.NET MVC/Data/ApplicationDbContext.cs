using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASP.NET_MVC.Models.Identity;
using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, int, IdentityUserClaim<int>, AppUserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserData> UserData { get; set; }

        public DbSet<Tasks> Tasks { get; set; }
    }
}