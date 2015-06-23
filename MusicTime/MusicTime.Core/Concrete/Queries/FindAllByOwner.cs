namespace MusicTime.Core.Concrete.Queries
{
    public class FindAllByOwner
    {
        public FindAllByOwner(string owner)
        {
            Owner = owner;
        }

        public string Owner { get; set; }
    }
}