using System.Collections.Generic;
using System.Linq;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Queries;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.PlaylistSteps
{
    [Binding]
    public class UpdatePlaylistSteps : StepBase
    {
        private int _playlistId;

        [Given(@"I have the following playlist in my list")]
        public void GivenIHaveTheFollowingPlaylistInMyList(Table table)
        {
            var command = table.CreateInstance<CreatePlaylistCommand>();
            command.Owner = Get<ISession>().CurrentUser;
            Get<ICommandHandler<CreatePlaylistCommand>>().Handle(command);
            _playlistId = Get<IQueryHandler<FindAllByOwner, List<Playlist>>>().Handle(new FindAllByOwner(command.Owner)).First().Id;
        }
        [When(@"I update this playlist with the following information")]
        public void WhenIUpdateThisPlaylistWithTheFollowingInformation(Table table)
        {
            var command = table.CreateInstance<UpdatePlaylistCommand>();
            command.Id = _playlistId;
            Get<ICommandHandler<UpdatePlaylistCommand>>().Handle(command);
        }
        [Then(@"My playlist list should be as follows")]
        public void ThenMyPlaylistListShouldBeAsFollows(Table table)
        {
            var owner = Get<ISession>().CurrentUser;
            var playlists =
            Get<IQueryHandler<FindAllByOwner, List<Playlist>>>().Handle(new FindAllByOwner(owner));
            table.CompareToSet(playlists);
        }
        public UpdatePlaylistSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
