using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordShop.Models.Login
{
    public class User    : IdentityUser
    {

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;


        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
