using System.Collections.Generic;
using MusicTime.Core.Abstract.Entities;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Handlers.Queries;
using MusicTime.Core.Concrete.Queries;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace MusicTime.Core.Tests.DI
{
    public class QueryModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x => x
                .FromAssemblyContaining<IEntity>()
                .SelectAllClasses()
                .InheritedFrom(typeof(IQueryHandler<,>))
                .BindAllInterfaces());

            Bind(typeof(IQueryHandler<FindAllQuery<Playlist>, List<Playlist>>)).To(typeof(FindAllQueryHandler<Playlist>));
            Bind(typeof (IQueryHandler<FindAllQuery<Song>, List<Song>>)).To(typeof (FindAllQueryHandler<Song>));
        }
    }
}