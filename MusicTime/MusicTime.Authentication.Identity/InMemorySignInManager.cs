using MusicTime.Core.Abstract.Authentication;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Authentication.Identity
{
    public class InMemorySignInManager : ISignInManager
    {
        private readonly ISession _sessionManager;

        public InMemorySignInManager(ISession sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public void SignIn(User user,
            bool isPersistent,
            bool rememberBrowser)
        {
            _sessionManager.CurrentUser = user.UserName;
        }
    }
}