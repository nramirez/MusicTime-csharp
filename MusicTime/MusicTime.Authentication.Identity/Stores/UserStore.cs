using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using MusicTime.Authentication.Identity.Models;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Authentication.Identity.Stores
{
    public class UserStore : IUserPasswordStore<IdentityUser, int>
    {
        private readonly IRepository<User> _users;
        private readonly IUnitOfWork _unitOfWork;

        public UserStore(IRepository<User> users, IUnitOfWork unitOfWork)
        {
            _users = users;
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(IdentityUser user)
        {
            var savedUser =_users.Add(new User()
            {
               UserName = user.UserName,
               PasswordHash = user.PasswordHash
            });
            _unitOfWork.Commit();
            user.Id = savedUser.Id;
            return Task.FromResult(user);
        }

        public Task UpdateAsync(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityUser> FindByIdAsync(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityUser> FindByNameAsync(string userName)
        {
            return Task.FromResult(_users.SingleOrDefault(u => u.UserName == userName).AsIdentityUser());
        }

        public Task SetPasswordHashAsync(IdentityUser user, string passwordHash)
        {
            user.PasswordHash = passwordHash;
            return Task.FromResult(0);
        }

        public Task<string> GetPasswordHashAsync(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}