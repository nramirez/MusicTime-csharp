using MusicTime.Core.Abstract.Authorization;

namespace MusicTime.Core.Tests.Mocks
{
    public class SessionMock : ISession
    {
        public string CurrentUser
        {
            get;
            set;
        }
    }
}