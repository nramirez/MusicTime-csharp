using System;
using System.Collections.Generic;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Handlers.Queries;
using MusicTime.Core.Entities;
using Should;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps
{
    [Binding]
    class CreatePlaylistSteps : StepBase
    {
        private string _username;
        private bool _unSuccessfulRequest;
        private string _error;

        [Given(@"I have registered and login as '(.*)'")]
        public void GivenIHaveRegisteredAndLoginAs(string username)
        {
            _username = username;
        }
        [When(@"I create a playlist with the following information")]
        public void WhenICreateAPlaylistWithTheFollowingInformation(Table table)
        {
            var command = table.CreateInstance<CreatePlaylistCommand>();
            _unSuccessfulRequest = false;
            try
            {
                Get<ICommandHandler<CreatePlaylistCommand>>().Handle(command);
            }
            catch (ArgumentException ex)
            {
                _error = ex.Message;
                _unSuccessfulRequest = true;
            }
        }

        [Then(@"My playlist list should be like follows")]
        public void ThenMyPlaylistListShouldBeLikeFollows(Table table)
        {
            var playlists = Get<IQueryHandler<FindAllQuery, List<Playlist>>>().Handle(new FindAllQuery());
            table.CompareToSet(playlists);
        }
        [Then(@"I should be informed that the playlist wasn't saved")]
        public void ThenIShouldBeInformedThatThePlaylistWasnTSaved()
        {
            _unSuccessfulRequest.ShouldBeTrue();
        }
        [Then(@"I should see an unsuccessful error message '(.*)'")]
        public void ThenIShouldSeeAnUnsuccessfulErrorMessage(string message)
        {
            _error.ShouldEqual(message);
        }

        public CreatePlaylistSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
