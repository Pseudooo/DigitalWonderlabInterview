using DigitalWonderlabInterview.ClientModel;
using MediatR;

namespace DigitalWonderlabInterview.Service.Commands;

public class AddFilmCommand : IRequest<FilmModel>
{
    public string FilmName { get; set; } = null!;
    public int Rating { get; set; }
}