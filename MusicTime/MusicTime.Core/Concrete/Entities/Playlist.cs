﻿using System.Collections.Generic;
using MusicTime.Core.Abstract.Entities;

namespace MusicTime.Core.Concrete.Entities
{
    public class Playlist : IEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Owner { get; set; }
        public virtual List<PlaylistSong> Songs { get; set; }
    }
}