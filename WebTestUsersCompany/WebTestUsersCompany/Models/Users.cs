using Microsoft.AspNetCore.Identity;

namespace WebTestUsersCompany.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
