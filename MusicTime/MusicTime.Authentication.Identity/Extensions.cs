using System.Collections.Generic;
using System.Linq;
using MusicTime.Authentication.Identity.Models;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Authentication.Identity
{
    public static class Extensions
    {
        public static IdentityUser AsIdentityUser(this User user)
        {
            return user == null
                ? null
                : new IdentityUser
                {
                    UserName = user.UserName,
                    PasswordHash = user.PasswordHash
                };
        }

        public static string ToErrorString(this  IEnumerable<string> errors)
        {
            return errors.Aggregate(string.Empty, (s, s1) => string.Format("{0}\n{1}", s, s1));
        }
    }
}