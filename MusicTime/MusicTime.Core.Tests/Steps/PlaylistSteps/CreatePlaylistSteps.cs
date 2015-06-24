using System.Collections.Generic;
using System.Linq;
using FluentValidation;
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
            try
            {
                Get<ICommandHandler<CreatePlaylistCommand>>().Handle(command);
            }
            catch (ValidationException ex)
            {
                SetValidationException(ex);
            }
        }

        [Then(@"My playlist list should be like follows")]
        public void ThenMyPlaylistListShouldBeLikeFollows(Table table)
        {
            var playlists = Get<IQueryHandler<FindAllQuery, List<Playlist>>>().Handle(new FindAllQuery());
            table.CompareToSet(playlists);
        }
        [Then(@"I should see an unsuccessful error message '(.*)'")]
        public void ThenIShouldSeeAnUnsuccessfulErrorMessage(string message)
        {
            GetValidationExeption().Errors.Any(e => e.ErrorMessage == message).ShouldBeTrue();
        }

        public CreatePlaylistSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
