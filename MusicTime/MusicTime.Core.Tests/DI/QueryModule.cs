using System.Collections.Generic;
using MusicTime.Core.Concrete.Handlers.Queries;
using MusicTime.Core.Entities;
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