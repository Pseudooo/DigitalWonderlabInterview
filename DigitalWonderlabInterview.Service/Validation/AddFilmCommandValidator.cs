using DigitalWonderlabInterview.Service.Commands;
using FluentValidation;

namespace DigitalWonderlabInterview.Service.Validation;

public class AddFilmCommandValidator : AbstractValidator<AddFilmCommand>
{
    public AddFilmCommandValidator()
    {
        RuleFor(x => x.FilmName)
            .NotEmpty();

        RuleFor(x => x.Rating)
            .InclusiveBetween(0, 5);
    }
}