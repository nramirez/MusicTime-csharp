using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Abstract.Authorization
{
    public interface ISession
    {
        string CurrentUser { get; set; }
        Role CurrentUserRole { get; set; }
    }
}