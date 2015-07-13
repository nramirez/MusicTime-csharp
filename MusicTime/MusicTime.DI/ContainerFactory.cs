using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Storage;
using MusicTime.DI.Mocks;
using MusicTime.Storage;
using Ninject;
using Ninject.Syntax;

namespace MusicTime.DI
{
    public class ContainerFactory
    {
        public static IResolutionRoot CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            kernel.Load<CommanHandlerModule>();

            kernel.Load<ValidatorModule>();

            kernel.Load<StorageModule>();

            kernel.Load<QueryModule>();

            kernel.Bind<ISession>().To<FakeSession>().InThreadScope();

            kernel.Load<AuthenticationModule>();

            return kernel;
        }
    }
}