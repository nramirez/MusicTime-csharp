using System;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Concrete.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AuthorizeAttribute : Attribute
    {
        public Role[] Roles { get; private set; }

        public AuthorizeAttribute(params  Role[] roles)
        {
            Roles = roles;
        }
    }
}