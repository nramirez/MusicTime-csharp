using FluentValidation;
using MusicTime.Core.Concrete.Commands;

namespace MusicTime.Core.Concrete.Handlers.Validators
{
    public class UpdatePlaylistCommandValidator : AbstractValidator<UpdatePlaylistCommand>
    {
        public UpdatePlaylistCommandValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(m => m.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
