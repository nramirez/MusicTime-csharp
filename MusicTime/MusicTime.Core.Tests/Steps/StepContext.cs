using MusicTime.Core.Tests.DI;
using Ninject.Syntax;

namespace MusicTime.Core.Tests.Steps
{
    public class StepContext
    {
        private IResolutionRoot _resolutionRoot;

        public IResolutionRoot ResolutionRoot
        {
            get { return _resolutionRoot ?? (_resolutionRoot = ContainerFactory.CreateKernel()); }
        }
    }
}