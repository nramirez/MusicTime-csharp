using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;
using Should;
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
        public void ThenIShouldBeLoggedInAs(string username)
        {
            Get<ISession>().CurrentUser.ShouldEqual(username);
        }
        protected UserRegistrationSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
