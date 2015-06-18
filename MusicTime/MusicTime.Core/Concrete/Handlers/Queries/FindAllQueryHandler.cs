using System.Collections.Generic;
using System.Linq;
using MusicTime.Core.Abstract.Entities;
using MusicTime.Core.Abstract.Storage;

namespace MusicTime.Core.Concrete.Handlers.Queries
{
    public class FindAllQueryHandler<T> : IQueryHandler<FindAllQuery, List<T>> where T : IEntity
    {
        private readonly IRepository<T> _repository;

        public FindAllQueryHandler(IRepository<T> repository)
        {
            _repository = repository;
        }

        public List<T> Handle(FindAllQuery query)
        {
            return _repository.ToList();
        }
    }
}