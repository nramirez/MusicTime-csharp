using System.Collections.Generic;
using System.Linq;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Enumerations;

namespace MusicTime.DI.Mocks
{
    public class SessionMock : ISession
    {
        private List<Role> _currentUserRoles;
        private string _currentUser;

        public string CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUserRoles = null;
                _currentUser = value;
            }
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