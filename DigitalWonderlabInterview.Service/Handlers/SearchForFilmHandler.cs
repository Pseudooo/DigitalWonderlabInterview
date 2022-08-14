using DigitalWonderlabInterview.ClientModel;
using DigitalWonderlabInterview.Domain.Interface;
using DigitalWonderlabInterview.Service.Queries;
using MapsterMapper;
using MediatR;

namespace DigitalWonderlabInterview.Service.Handlers;

public class SearchForFilmHandler : IRequestHandler<SearchForFilmQuery, IEnumerable<FilmModel>>
{
    private readonly IFilmRepository _filmRepository;
    private readonly IMapper _mapper;

    public SearchForFilmHandler(IFilmRepository filmRepository, IMapper mapper)
    {
        _filmRepository = filmRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FilmModel>> Handle(SearchForFilmQuery request, CancellationToken cancellationToken)
    {
        var result = await _filmRepository.SearchForFilm(request.SearchTerm);

        var filmModels = _mapper.Map<IEnumerable<FilmModel>>(result);

        return filmModels;
    }
}