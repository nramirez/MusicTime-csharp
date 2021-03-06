﻿using FluentValidation;
using MusicTime.Core.Abstract.Handlers.Commands;

namespace MusicTime.Core.Concrete.Handlers.Decorators
{
    public class ValidationCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    {
        private readonly ICommandHandler<TCommand> _handler;
        private readonly IValidator<TCommand> _validator;

        public ValidationCommandHandlerDecorator(ICommandHandler<TCommand> handler, IValidator<TCommand> validator)
        {
            _handler = handler;
            _validator = validator;
        }

        public void Handle(TCommand command)
        {
            _validator.ValidateAndThrow(command);
            _handler.Handle(command);
        }

    }
}