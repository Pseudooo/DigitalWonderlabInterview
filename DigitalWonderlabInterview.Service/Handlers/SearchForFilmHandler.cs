using DigitalWonderlabInterview.ClientModel;
using DigitalWonderlabInterview.Domain.Interface;
using DigitalWonderlabInterview.Service.Queries;
using MediatR;

namespace DigitalWonderlabInterview.Service.Handlers;

public class SearchForFilmHandler : IRequestHandler<SearchForFilmQuery, IEnumerable<FilmModel>>
{
    private readonly IFilmRepository _filmRepository;

    public SearchForFilmHandler(IFilmRepository filmRepository)
    {
        _filmRepository = filmRepository;
    }

    public async Task<IEnumerable<FilmModel>> Handle(SearchForFilmQuery request, CancellationToken cancellationToken)
    {
        var result = await _filmRepository.SearchForFilm(request.SearchTerm);

        var filmModels = result.Select(filmEntity => new FilmModel() { Id = filmEntity.Id, Name = filmEntity.Name });

        return filmModels;
    }
}