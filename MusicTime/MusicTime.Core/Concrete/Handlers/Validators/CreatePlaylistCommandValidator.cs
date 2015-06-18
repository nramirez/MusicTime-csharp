using System;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Concrete.Commands;

namespace MusicTime.Core.Concrete.Handlers.Validators
{
    public class CreatePlaylistCommandValidator : IValidator<CreatePlaylistCommand>
    {
        
        public void Validate(CreatePlaylistCommand command)
        {
            if (String.IsNullOrEmpty(command.Name))
            {
                throw new ArgumentException("Name is required");
            }
        }
    }
}
