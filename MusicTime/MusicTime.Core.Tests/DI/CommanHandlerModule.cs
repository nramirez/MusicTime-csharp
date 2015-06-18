using MusicTime.Core.Abstract.Entities;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;
using Ninject.Modules;
using Ninject.Extensions.Conventions;

namespace MusicTime.Core.Tests.DI
{
    public class CommanHandlerModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(ICommandHandler<>))
                .To(typeof(ValidatorCommandHandlerDecorator<>));

            Kernel.Bind(
                k => k.FromAssemblyContaining<IEntity>()
                .SelectAllClasses()
                .InheritedFrom(typeof(ICommandHandler<>)
                ).Excluding(typeof(ValidatorCommandHandlerDecorator<>))
                .BindAllInterfaces()
                .Configure(x => x.WhenInjectedInto(typeof(ValidatorCommandHandlerDecorator<>)))
                );
        }
    }
}