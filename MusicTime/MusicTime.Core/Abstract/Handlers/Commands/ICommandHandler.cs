using MusicTime.Core.Concrete.Commands;

namespace MusicTime.Core.Abstract.Handlers.Commands
{
    public interface ICommandHandler<T>
    {
        void Handle(CreatePlaylistCommand command);
    }
}