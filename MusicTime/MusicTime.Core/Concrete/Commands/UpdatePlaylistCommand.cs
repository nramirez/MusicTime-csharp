namespace MusicTime.Core.Concrete.Commands
{
    public class UpdatePlaylistCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
    }
}