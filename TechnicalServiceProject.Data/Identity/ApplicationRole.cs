using Microsoft.AspNetCore.Identity;

namespace TechnicalServiceProject.Data.Identity
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }


    }
}
