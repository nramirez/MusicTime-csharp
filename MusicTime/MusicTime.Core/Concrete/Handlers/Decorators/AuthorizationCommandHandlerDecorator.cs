using System;
using System.Linq;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Attributes;

namespace MusicTime.Core.Concrete.Handlers.Decorators
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

            var attribute = command.GetType()
                .GetCustomAttributes(typeof(AuthorizeAttribute),false)
                .FirstOrDefault() as AuthorizeAttribute;
            if (attribute != null &&
                !attribute.Roles.Any(role => _session.UserIsInRole(role)))
                throw new UnauthorizedAccessException();
            _decorated.Handle(command);
        }
    }
}