using System.Data.Common;
using System.Data.Entity;
using Effort;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Storage;
using Ninject.Modules;

namespace MusicTime.DI
{
    public class StorageModule : NinjectModule, INinjectModule
    {
        public override void Load()
        {
            Bind(typeof(DbContext)).To<MusicTimeDbContext>().InThreadScope();
            //TODO: When we move this to a DI Project, then we have to verify if we are in test mode or in production mode
            Bind<DbConnection>().ToConstant(DbConnectionFactory.CreateTransient()).InThreadScope();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            
        }
    }
}