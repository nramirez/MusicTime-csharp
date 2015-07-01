using Microsoft.AspNet.Identity;

namespace MusicTime.Authentication.Identity.Models
{
    public class IdentityUser : IUser<int>
    {
        public int Id { get; set; }

        public string UserName
        {
            get;
            set;
        }

        public string PasswordHash { get; set; }
    }
}