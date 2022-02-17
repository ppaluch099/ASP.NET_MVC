using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASP.NET_MVC.Models.Identity;

namespace ASP.NET_MVC.Models
{
    public class UserData
    {
        [Key, ForeignKey("AppUser")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public virtual AppUser? AppUser { get; set; }
    }
}
