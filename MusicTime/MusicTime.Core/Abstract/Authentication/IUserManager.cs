using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Abstract.Authentication
{
    public interface IUserManager
    {
        User Create(string email, string password);
    }
}