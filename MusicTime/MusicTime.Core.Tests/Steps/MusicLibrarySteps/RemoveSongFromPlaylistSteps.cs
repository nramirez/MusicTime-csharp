using System.Data.Entity;
using System.Linq;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Storage;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.MusicLibrarySteps
{
    [Binding]
    class RemoveSongFromPlaylistSteps : StepBase
    {
        private Playlist _playlist;

        [Given(@"'(.*)' playlist has the following songs")]
        public void GivenPlaylistHasTheFollowingSongs(string playlistName, Table table)
        {

            var context = Get<DbContext>() as MusicTimeDbContext;
            _playlist = context.Playlists.First(p => p.Name == playlistName);


            var songs = table.CreateSet<Song>().ToList();

            songs.ForEach(s => context.Songs.Add(s));
            context.SaveChanges();

            songs.ForEach(s => context.PlaylistSongs.Add(new PlaylistSong()
            {
                PlaylistId = _playlist.Id,
                SongId = s.Id
            }));
            context.SaveChanges();
        }

        [When(@"I clicked to remove the song '(.*)'")]
        public void WhenIClickedToRemoveTheSong(string songName)
        {
            var id = _playlist.Songs.First(s => s.Song.Name == songName).Id;
            Get<ICommandHandler<RemoveSongFromPlaylistCommand>>().Handle(new RemoveSongFromPlaylistCommand()
            {
                Id = id
            });
        }

        protected RemoveSongFromPlaylistSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
