using System.Collections.Generic;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Handlers.Queries;
using MusicTime.Core.Entities;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps
{
    [Binding]
    class CreatePlaylistSteps : StepBase
    {
        private string _username;

        [Given(@"I have registered and login as '(.*)'")]
        public void GivenIHaveRegisteredAndLoginAs(string username)
        {
            _username = username;
        }

        

        [When(@"I create a playlist with the following information")]
        public void WhenICreateAPlaylistWithTheFollowingInformation(Table table)
        {
            var command = table.CreateInstance<CreatePlaylistCommand>();
            Get<ICommandHandler<CreatePlaylistCommand>>().Handle(command);
        }

        [Then(@"My playlist list should be like follows")]
        public void ThenMyPlaylistListShouldBeLikeFollows(Table table)
        {

            var playlists = Get<IQueryHandler<FindAllQuery, List<Playlist>>>().Handle(new FindAllQuery());

            table.CompareToSet(playlists);
        }

        public CreatePlaylistSteps(StepContext stepContext) : base(stepContext)
        {
        }
    }
}
