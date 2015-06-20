using FluentValidation;
using MusicTime.Core.Concrete.Commands;

namespace MusicTime.Core.Concrete.Handlers.Validators
{
    public class CreatePlaylistCommandValidator : AbstractValidator<CreatePlaylistCommand>
    {

        public CreatePlaylistCommandValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
