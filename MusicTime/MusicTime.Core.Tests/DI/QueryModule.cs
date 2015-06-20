using System.Collections.Generic;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Handlers.Queries;
using Ninject.Modules;

namespace MusicTime.Core.Tests.DI
{
    public class QueryModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IQueryHandler<FindAllQuery, List<Playlist>>>().To<FindAllQueryHandler<Playlist>>();
        }
    }
}