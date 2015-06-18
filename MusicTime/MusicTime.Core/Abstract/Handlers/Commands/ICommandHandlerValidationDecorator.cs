namespace MusicTime.Core.Abstract.Handlers.Commands
{

    public interface IValidator<in TCommand>
    {
        void Validate(TCommand command);
    }
}
