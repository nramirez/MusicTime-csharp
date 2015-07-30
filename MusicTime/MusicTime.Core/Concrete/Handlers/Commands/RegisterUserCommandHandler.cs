using MusicTime.Core.Abstract.Authentication;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;

namespace MusicTime.Core.Concrete.Handlers.Commands
{
    public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand>
    {
        private readonly IUserManager _userManager;
        private readonly ISignInManager _signInManager;

        public RegisterUserCommandHandler(IUserManager userManager, ISignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void Handle(RegisterUserCommand command)
        {
            var user = _userManager.Create(command.Email, command.Password);

            _signInManager.SignIn(user, false, false);
        }
    }
}