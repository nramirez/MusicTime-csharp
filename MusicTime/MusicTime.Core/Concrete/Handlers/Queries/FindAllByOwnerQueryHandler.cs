using System.Collections.Generic;
using System.Linq;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Queries;

namespace MusicTime.Core.Concrete.Handlers.Queries
{
    public class FindAllByOwnerQueryHandler : IQueryHandler<FindAllByOwner, List<Playlist>>
    {
        private readonly IRepository<Playlist> _repository;

        public FindAllByOwnerQueryHandler(IRepository<Playlist> repository)
        {
            _repository = repository;
        }

        public List<Playlist> Handle(FindAllByOwner query)
        {
            return _repository.Where(p => p.Owner == query.Owner).ToList();

        }
    }
}
