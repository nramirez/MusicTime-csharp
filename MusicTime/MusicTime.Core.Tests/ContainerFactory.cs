using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using Effort;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Handlers.Commands;
using MusicTime.Core.Concrete.Handlers.Queries;
using MusicTime.Core.Entities;
using MusicTime.Storage;
using Ninject;
using Ninject.Syntax;

namespace MusicTime.Core.Tests
{
    internal class ContainerFactory
    {
        public static IResolutionRoot CreateKernel()
        {

            var kernel = new StandardKernel();
           
            kernel.Bind(typeof(DbContext)).To<MusicTimeDbContext>().InThreadScope();

            //TODO: When we move this to a DI Project, then we have to verify if we are in test mode or in production mode
            kernel.Bind<DbConnection>().ToConstant(DbConnectionFactory.CreateTransient()).InThreadScope();
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            kernel.Bind<ICommandHandler<CreatePlaylistCommand>>().To<CreatePlaylistCommandHandler>();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IQueryHandler<FindAllQuery, List<Playlist>>>().To<FindAllQueryHandler<Playlist>>();
            return kernel;
        }
    }
}