using System;
using System.Linq;
using System.Linq.Expressions;
using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Abstract.Storage
{
    public interface IRepository<T> : IQueryable<T> where T : IEntity
    {
        void Add(T entity);
        T Single(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> lambdaFilter);
        void Remove(T entity);
    }
}