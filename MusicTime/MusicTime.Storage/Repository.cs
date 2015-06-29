using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using MusicTime.Core.Abstract.Entities;
using MusicTime.Core.Abstract.Storage;

namespace MusicTime.Storage
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbcontext;
        private IDbSet<T> Set { get { return _dbcontext.Set<T>(); } }
        public Repository(DbContext context)
        {
            _dbcontext = context;
        }
        public void Add(T entity)
        {
            Set.Add(entity);
        }

        public T Single(int id)
        {
            return Set.Single(e => e.Id == id);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> lambdaFilter)
        {
            return Set.Where(lambdaFilter);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Set.GetEnumerator();
        }
        [ExcludeFromCodeCoverage]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        [ExcludeFromCodeCoverage]
        public Expression Expression
        {
            get { return Set.Expression; }
        }
        [ExcludeFromCodeCoverage]
        public Type ElementType
        {
            get { return Set.ElementType; }
        }
        [ExcludeFromCodeCoverage]
        public IQueryProvider Provider
        {
            get { return Set.Provider; }
        }
    }
}