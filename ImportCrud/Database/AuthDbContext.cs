using ImportCrud.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ImportCrud.Database
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext()
            : base("DbConnection", throwIfV1Schema: false)
        {
        }

        public static AuthDbContext Create()
        {
            return new AuthDbContext();
        }
    }
}