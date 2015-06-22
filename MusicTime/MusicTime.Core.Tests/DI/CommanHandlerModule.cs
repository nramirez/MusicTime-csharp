using MusicTime.Core.Abstract.Entities;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Handlers.Decorators;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace MusicTime.Core.Tests.DI
{
    public class CommanHandlerModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(ICommandHandler<>))
                .To(typeof(AuthorizationCommandHandlerDecorator<>));


            Bind(typeof(ICommandHandler<>))
                .To(typeof(ValidationCommandHandlerDecorator<>))
                .WhenInjectedInto(typeof(AuthorizationCommandHandlerDecorator<>));

            Kernel.Bind(syntax => syntax
                .FromAssemblyContaining<IEntity>()
                .SelectAllClasses()
                .InheritedFrom(typeof(ICommandHandler<>))
                .Excluding(typeof(ValidationCommandHandlerDecorator<>))
                .Excluding(typeof(AuthorizationCommandHandlerDecorator<>))
                .BindAllInterfaces()
                .Configure(x => x.WhenInjectedInto(typeof(ValidationCommandHandlerDecorator<>))));
        }
    }
}