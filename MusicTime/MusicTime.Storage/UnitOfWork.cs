using System.Data.Entity;
using MusicTime.Core.Abstract.Storage;

namespace MusicTime.Storage
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
    }
}