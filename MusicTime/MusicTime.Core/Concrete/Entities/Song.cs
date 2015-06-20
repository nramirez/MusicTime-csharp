using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Concrete.Entities
{
    public class Song : IEntity
    {
        public int Id
        {
            get;
            set;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string StreamId { get; set; }
        public string Genre { get; set; }
    }
}