using FluentValidation;
using MusicTime.Core.Concrete.Commands;

namespace MusicTime.Core.Concrete.Handlers.Validators
{
   public class UpdateSongCommandValidator : AbstractValidator<UpdateSongCommand>
   {
       public UpdateSongCommandValidator()
       {
           RuleFor(m => m.Name).NotEmpty().WithMessage("Name is required");
           RuleFor(m => m.Description).NotEmpty().WithMessage("Description is required");
           RuleFor(m => m.StreamId).NotEmpty().WithMessage("StreamId is required");
           RuleFor(m => m.Genre).NotEmpty().WithMessage("Genre is required");
       }
    }
}
