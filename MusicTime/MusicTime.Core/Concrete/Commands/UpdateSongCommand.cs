﻿using MusicTime.Core.Concrete.Attributes;
using MusicTime.Core.Enumerations;

namespace MusicTime.Core.Concrete.Commands
{
    [Authorize(Role.Admin)]
    public class UpdateSongCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string StreamId { get; set; }
    }
}