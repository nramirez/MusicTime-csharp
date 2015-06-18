using MusicTime.Core.Abstract.Handlers.Commands;

namespace MusicTime.Core.Concrete.Commands
{
    public class ValidatorCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    {
        private readonly ICommandHandler<TCommand> _handler;
        private readonly IValidator<TCommand> _validator;

        public ValidatorCommandHandlerDecorator(ICommandHandler<TCommand> handler, IValidator<TCommand> validator)
        {
            _handler = handler;
            _validator = validator;
        }

        public void Handle(TCommand command)
        {
            _validator.Validate(command);
            _handler.Handle(command);
        }

    }
}