using DigitalWonderlabInterview.ClientModel;
using MediatR;

namespace DigitalWonderlabInterview.Service.Queries;

public class SearchForFilmQuery : IRequest<IEnumerable<FilmModel>>
{
    public string SearchTerm { get; set; } = null!;
}