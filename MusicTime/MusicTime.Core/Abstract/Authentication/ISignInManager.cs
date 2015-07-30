using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Abstract.Authentication
{
    public interface ISignInManager
    {
        void SignIn(User user, bool isPersistent, bool rememberBrowser);
    }
}