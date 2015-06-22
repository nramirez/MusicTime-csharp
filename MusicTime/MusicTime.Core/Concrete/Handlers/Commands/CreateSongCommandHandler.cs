using System;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Attributes;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Concrete.Handlers.Commands
{
    [Authorize(Role.Admin)]
    public class CreateSongCommandHandler : ICommandHandler<CreateSongCommand>
    {
        private readonly IRepository<Song> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateSongCommandHandler(IRepository<Song> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(CreateSongCommand command)
        {
            _repository.Add(new Song()
            {
                Name = command.Name,
                Description = command.Description,
                StreamId = command.StreamId,
                Genre = command.Genre,
            });
            _unitOfWork.Commit();
        }
    }
}
