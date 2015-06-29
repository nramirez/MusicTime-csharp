using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Handlers.Commands;

namespace MusicTime.Core.Concrete.Handlers
{
    public class AddSongToPlylistCommandHandler : ICommandHandler<AddSongToPlaylistCommand>
    {
        private readonly IRepository<PlaylistSong> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public AddSongToPlylistCommandHandler(IRepository<PlaylistSong> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(AddSongToPlaylistCommand command)
        {
            _repository.Add(new PlaylistSong()
            {
                PlaylistId = command.PlaylistId,
                SongId = command.SongId,
            });
            _unitOfWork.Commit();
        }
    }
}