using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ChirpChirp.Domain
{
    public class AuthRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthRepository(AuthContext ctx)
        {
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(ctx));
        }

        public async Task<IdentityResult> RegisterUser(string username, string password)
        {
            var user = new IdentityUser
            {
                UserName = username
            };
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            var user = await _userManager.FindAsync(userName, password);
            return user;
        }
    }
}