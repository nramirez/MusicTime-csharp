using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.Authentication
{
    [Binding]
    public class UserRegistrationSteps : StepBase
    {
        [When(@"I register with the following info")]
        public void WhenIRegisterWithTheFollowingInfo(Table table)
        {
            var registerCommand = table.CreateInstance<RegisterUserCommand>();
            Get<ICommandHandler<RegisterUserCommand>>().Handle(registerCommand);
        }
        [Then(@"I should be logged in as '(.*)'")]
        public void ThenIShouldBeLoggedInAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        protected UserRegistrationSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
