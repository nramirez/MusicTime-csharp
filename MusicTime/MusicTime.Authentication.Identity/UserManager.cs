using System.Security.Authentication;
using Microsoft.AspNet.Identity;
using MusicTime.Authentication.Identity.Models;
using MusicTime.Core.Abstract.Authentication;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Authentication.Identity
{
    public class UserManager : IUserManager
    {
        private readonly UserManager<IdentityUser, int> _identityUserManager;

        public UserManager(UserManager<IdentityUser, int> identityUserManager)
        {
            _identityUserManager = identityUserManager;
        }

        public User Create(string email, string password)
        {
            var user = new IdentityUser { UserName = email };
            var result = _identityUserManager.Create(user, password);
            
            if (!result.Succeeded)
                throw new AuthenticationException(result.Errors.ToErrorString());

            return new User
            {
                Id = user.Id,
                UserName = email,
            };
        }
    }




}