using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Tests.Mocks
{
    public class SessionMock : ISession
    {
        public string CurrentUser
        {
            get;
            set;
        }

        public Role CurrentUserRole
        {
            get;
            set;
        }
    }
}