using System;
using System.Linq;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Attributes;

namespace MusicTime.Core.Concrete.Handlers.Decorators
{
    public class AuthorizationCommandHandlerDecorator<T> : ICommandHandler<T>
    {
        private readonly ICommandHandler<T> _handler;
        private readonly ISession _session;

        public AuthorizationCommandHandlerDecorator(ICommandHandler<T> handler, ISession session)
        {
            _handler = handler;
            _session = session;
        }

        public void Handle(T command)
        {
            var attribute = typeof(T)
                .GetCustomAttributes(typeof(AuthorizeAttribute),false)
                .FirstOrDefault() as AuthorizeAttribute;
         
            if (attribute != null &&
                !attribute.Roles.Any(role => _session.UserIsInRole(role)))
                throw new UnauthorizedAccessException();
            
            _handler.Handle(command);
        }
    }
}