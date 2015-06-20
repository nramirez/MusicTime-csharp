using System.Linq;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Concrete.Handlers.Commands
{
    public class UpdatePlaylistCommandHandler : ICommandHandler<UpdatePlaylistCommand>
    {
        private readonly IRepository<Playlist> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePlaylistCommandHandler(IRepository<Playlist> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(UpdatePlaylistCommand command)
        {
            var existing = _repository.Single(u => u.Id == command.Id);
            existing.Name = command.Name;
            existing.Description = command.Description;
            _unitOfWork.Commit();
        }
    }
}
