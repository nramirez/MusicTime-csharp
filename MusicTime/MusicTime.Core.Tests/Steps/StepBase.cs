using Ninject;

namespace MusicTime.Core.Tests.Steps
{
    internal class StepBase
    {
        private readonly StepContext _stepContext;

        public StepBase(StepContext stepContext)
        {
            _stepContext = stepContext;
        }
        protected T Get<T>()
        {
            return _stepContext.ResolutionRoot.Get<T>();
        }
    }
}