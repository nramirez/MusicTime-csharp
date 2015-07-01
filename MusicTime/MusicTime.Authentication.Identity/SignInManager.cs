using Microsoft.AspNet.Identity.Owin;
using MusicTime.Authentication.Identity.Models;
using MusicTime.Core.Abstract.Authentication;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Authentication.Identity
{
    public class SignInManager : ISignInManager
    {
        private readonly SignInManager<IdentityUser, int> _identitySignInManager;

        public SignInManager(SignInManager<IdentityUser, int> identitySignInManager)
        {
            _identitySignInManager = identitySignInManager;
        }

        public void SignIn(User user, bool isPersistent, bool rememberBrowser)
        {
            _identitySignInManager.SignIn(user.AsIdentityUser(),isPersistent, rememberBrowser);
        }
    }
}