namespace MusicTime.Core.Abstract.Handlers.Commands
{
    public interface ICommandHandler<in T>
    {
        void Handle(T command);
    }
}