using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Concrete.Entities
{
    public class Playlist : IEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}