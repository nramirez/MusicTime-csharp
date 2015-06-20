using System.Collections.Generic;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Handlers.Queries;
using MusicTime.Core.Concrete.Queries;
using Ninject.Modules;

namespace MusicTime.Core.Tests.DI
{
    public class QueryModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof (IQueryHandler<FindAllQuery, List<Playlist>>)).To(typeof (FindAllQueryHandler<Playlist>));
            Bind(typeof (IQueryHandler<FindAllByOwner, List<Playlist>>)).To(typeof (FindAllByOwnerQueryHandler));

        }
    }
}