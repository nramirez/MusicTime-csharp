using System.Data.Common;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using MusicTime.Core.Concrete.Entities;

namespace MusicTime.Storage
{
    public class MusicTimeDbContext : DbContext
    {
        [ExcludeFromCodeCoverage]
        public MusicTimeDbContext()
        {

        }

        public MusicTimeDbContext(DbConnection connection)
            : base(connection, true)
        {
        }

        public IDbSet<Playlist> Playlists { get; set; }

    }
}
