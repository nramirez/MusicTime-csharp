using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Queries;
using Should;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.PlaylistSteps
{
    [Binding]
    class CreatePlaylistSteps : StepBase
    {
        private bool _unSuccessfulRequest;
        private IEnumerable<ValidationFailure> _errors;

        [Given(@"I am login as '(.*)'")]
        [Given(@"I have registered and login as '(.*)'")]
        [Given(@"my friend login as '(.*)'")]
        public void GivenIHaveRegisteredAndLoginAs(string username)
        {
            Get<ISession>().CurrentUser = username;
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
            catch (ValidationException ex)
            {
                _errors = ex.Errors;
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
            _errors.Any(e => e.ErrorMessage == message).ShouldBeTrue();
        }

        public CreatePlaylistSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
