using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using MusicTime.Authentication.Identity;
using MusicTime.Authentication.Identity.Models;
using MusicTime.Authentication.Identity.Stores;
using MusicTime.Core.Abstract.Authentication;
using Ninject.Modules;

namespace MusicTime.Core.Tests.DI
{
    public class AuthenticationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserManager>().To<UserManager>();
            Bind<IUserStore<IdentityUser, int>>().To<UserStore>();
            Bind<ISignInManager>().To<SignInManager>();
            Bind<IAuthenticationManager>().To<AuthenticationManager>();
        }
    }
}