using System.Collections.Generic;
using MusicTime.Core.Abstract.Queries;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Core.Concrete.Queries
{
    public class FindAllByOwner : IQuery<List<Playlist>>
    {
        public FindAllByOwner(string owner)
        {
            Owner = owner;
        }

        public string Owner { get; set; }
    }
}