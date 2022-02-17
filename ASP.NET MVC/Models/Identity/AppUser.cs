using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC.Models.Identity
{
    public class AppUser : IdentityUser<int>
    {
        [NotMapped]
        public bool EmailConfirmed { get; set; }

        [NotMapped]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public bool PhoneNumberConfirmed { get; set; }

        [NotMapped]
        public bool TwoFactorEnabled { get; set; }

        [NotMapped]
        public DateTimeOffset LockoutEnd { get; set; }

        [NotMapped]
        public bool LockoutEnabled { get; set; }

        [NotMapped]
        public int AccessFailedCount { get; set; }

        public virtual UserData UserData { get; set; }
    }
}
