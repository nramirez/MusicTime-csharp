using Ninject;

namespace MusicTime.Core.Tests.Steps
{
    public class StepBase
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