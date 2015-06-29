namespace MusicTime.Core.Concrete.Handlers.Commands
{
    public class AddSongToPlaylistCommand
    {
        public int PlaylistId { get; set; }
        public int SongId { get; set; }
    }
}