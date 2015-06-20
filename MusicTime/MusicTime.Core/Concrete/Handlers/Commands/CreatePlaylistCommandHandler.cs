using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Concrete.Handlers.Commands
{
    public class CreatePlaylistCommandHandler : ICommandHandler<CreatePlaylistCommand>
    {
        private readonly IRepository<Playlist> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePlaylistCommandHandler(IRepository<Playlist> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(CreatePlaylistCommand command)
        {
            _repository.Add(new Playlist
            {
                Name = command.Name,
                Description = command.Description
            });

            _unitOfWork.Commit();
        }
    }
}