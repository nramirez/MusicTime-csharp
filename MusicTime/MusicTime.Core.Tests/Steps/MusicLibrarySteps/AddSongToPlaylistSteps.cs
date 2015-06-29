using System.Collections.Generic;
using System.Linq;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Abstract.Storage;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Handlers.Commands;
using MusicTime.Core.Concrete.Queries;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.MusicLibrarySteps
{
    [Binding]
    public class AddSongToPlaylistSteps : StepBase
    {
        private Song _song;

        [Given(@"the following song exists in the global library")]
        public void GivenTheFollowingSongExistsInTheGlobalLibrary(Table table)
        {
            //We won't use the command to add this one, to avoid FluentValidation
            //and Authorization validation and allow to test following steps
            var playlists = Get<IRepository<Song>>();
            playlists.Add(table.CreateInstance<Song>());
            Get<IUnitOfWork>().Commit();
        }
        [When(@"I search for the song with the name '(.*)'")]
        public void WhenISearchForTheSongWithTheName(string songName)
        {
            _song =
                Get<IQueryHandler<FindAllQuery<Song>, List<Song>>>()
                    .Handle(new FindAllQuery<Song>(s => s.Name == songName)).First();

        }
        [When(@"add it to my '(.*)' playlist")]
        public void WhenAddItToMyPlaylist(string playlistName)
        {
            var playlist = GetFirstPlaylistByName(playlistName);

            Get<ICommandHandler<AddSongToPlaylistCommand>>()
                .Handle(new AddSongToPlaylistCommand
                {
                    PlaylistId = playlist.Id,
                    SongId = _song.Id,
                });
        }
        [Then(@"songs in my '(.*)' playlist should be as follow")]
        public void ThenSongsInMyPlaylistShouldBeAsFollow(string playlistName, Table table)
        {
            var playlist = GetFirstPlaylistByName(playlistName);
            var songs = playlist.Songs.Select(s => s.Song);
            table.CompareToSet(songs);

        }
        #region helper method
        private Playlist GetFirstPlaylistByName(string playlistName)
        {
            return Get<IQueryHandler<FindAllQuery<Playlist>, List<Playlist>>>()
                .Handle(new FindAllQuery<Playlist>(s => s.Name == playlistName)).First();
        }
        #endregion
        protected AddSongToPlaylistSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
