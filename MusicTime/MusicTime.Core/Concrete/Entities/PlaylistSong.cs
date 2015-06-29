using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Concrete.Entities
{
    public class PlaylistSong : IEntity
    {
        public int Id
        {
            get;
            set;
        }
        public int PlaylistId { get; set; }
        public int SongId { get; set; }
        public virtual Song Song { get; set; }
    }
}