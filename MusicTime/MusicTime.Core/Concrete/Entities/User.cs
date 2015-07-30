using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Concrete.Entities
{
    public class User : IEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public int Id
        {
            get;
            set;
        }
    }
}