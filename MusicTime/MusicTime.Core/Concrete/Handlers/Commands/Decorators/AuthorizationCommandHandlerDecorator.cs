using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Attributes;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Concrete.Handlers.Commands.Decorators
{
    public class AuthorizationCommandHandlerDecorator<T> : ICommandHandler<T>
    {
        private readonly ICommandHandler<T> _decorated;
        private readonly ISession _session;

        public AuthorizationCommandHandlerDecorator(ICommandHandler<T> decorated, ISession session)
        {
            _decorated = decorated;
            _session = session;
        }

        public void Handle(T command)
        {
            var attribute = _decorated.GetType()
                .GetCustomAttributes(typeof(AuthorizeAttribute),false)
                .FirstOrDefault() as AuthorizeAttribute;
            if (attribute != null &&
                !attribute.Roles.Any(role => _session.UserIsInRole(role)))
                throw new AuthenticationException();
            _decorated.Handle(command);
        }
    }
}