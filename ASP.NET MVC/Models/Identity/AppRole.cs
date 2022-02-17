using Microsoft.AspNetCore.Identity;

namespace ASP.NET_MVC.Models.Identity
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole()
        {
        }

        public AppRole(string roleName) : base(roleName)
        {
        }
    }
}
