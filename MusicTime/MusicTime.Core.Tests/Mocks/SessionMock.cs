using System.Collections.Generic;
using System.Linq;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Tests.Mocks
{
    public class SessionMock : ISession
    {
        private List<Role> _currentUserRoles;

        public string CurrentUser
        {
            get;
            set;
        }

        public List<Role> CurrentUserRoles
        {
            get { return _currentUserRoles ?? (_currentUserRoles = new List<Role>()); }
            set { _currentUserRoles = value; }
        }

        public bool UserIsInRole(Role role)
        {
            return CurrentUserRoles.Any(r => r == role);
        }
    }
}