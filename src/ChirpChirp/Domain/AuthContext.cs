using ChirpChirp.Settings;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ChirpChirp.Domain
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext(DbConnectionString dbConnectionString) : base(dbConnectionString)
        {
        }
    }
}