using System.Linq;
using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Abstract.Storage
{
    public interface IRepository<T> : IQueryable<T> where T : IEntity
    {
        void Add(T entity);
    }
}