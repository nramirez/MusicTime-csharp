using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Concrete.Handlers.Commands
{
    public class UpdateSongCommandHandler : ICommandHandler<UpdateSongCommand>
    {
        private readonly IRepository<Song> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateSongCommandHandler(IRepository<Song> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(UpdateSongCommand command)
        {
            var entity = _repository.Single(command.Id);
            entity.Name = command.Name;
            entity.Description = command.Description;
            entity.Genre = command.Genre;
            entity.StreamId = command.StreamId;
            _unitOfWork.Commit();
        }
    }
}