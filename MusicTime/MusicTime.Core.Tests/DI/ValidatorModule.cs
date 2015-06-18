using MusicTime.Core.Abstract.Entities;
using MusicTime.Core.Abstract.Handlers.Commands;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace MusicTime.Core.Tests.DI
{
    public class ValidatorModule : NinjectModule
    {
        public override void Load()
        {
             Kernel.Bind(k => k
                 .FromAssemblyContaining<IEntity>()
                 .SelectAllClasses()
                 .InheritedFrom(typeof(IValidator<>))
                 .BindAllInterfaces());
        }
    }
}