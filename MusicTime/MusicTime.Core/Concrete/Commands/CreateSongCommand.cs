namespace MusicTime.Core.Concrete.Commands
{
    public class CreateSongCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string StreamId { get; set; }
        public string Genre { get; set; }
    }
}