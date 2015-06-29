using System.Linq;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Concrete.Handlers.Commands
{
    public class RemoveSongFromPlaylistCommandHandler : ICommandHandler<RemoveSongFromPlaylistCommand>
    {
        private readonly IRepository<PlaylistSong> _repository;
        private readonly IUnitOfWork _uniOfWork;

        public RemoveSongFromPlaylistCommandHandler(IRepository<PlaylistSong> repository, IUnitOfWork uniOfWork)
        {
            _repository = repository;
            _uniOfWork = uniOfWork;
        }

        public void Handle(RemoveSongFromPlaylistCommand command)
        {
            var song = _repository.First(s => s.Id == command.Id);
            _repository.Remove(song);
            _uniOfWork.Commit();
        }
    }
}