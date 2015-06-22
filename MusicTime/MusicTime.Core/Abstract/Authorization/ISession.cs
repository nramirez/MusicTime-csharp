using System.Collections.Generic;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Abstract.Authorization
{
    public interface ISession
    {
        string CurrentUser { get; set; }
        List<Role> CurrentUserRoles { get; set; }
        bool UserIsInRole(Role role);
    }
}