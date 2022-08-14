using DigitalWonderlabInterview.ClientModel;
using DigitalWonderlabInterview.Domain.Entities;
using DigitalWonderlabInterview.Domain.Interface;
using DigitalWonderlabInterview.Service.Commands;
using MapsterMapper;
using MediatR;

namespace DigitalWonderlabInterview.Service.Handlers;

public class AddFilmHandler : IRequestHandler<AddFilmCommand, FilmModel>
{
    private readonly IBaseRepository<FilmEntity> _baseRepository;
    private readonly IMapper _mapper;

    public AddFilmHandler(IBaseRepository<FilmEntity> baseRepository, IMapper mapper) 
    {
        _baseRepository = baseRepository;
        _mapper = mapper;
    }

    public async Task<FilmModel> Handle(AddFilmCommand request, CancellationToken cancellationToken)
    {
        var filmEntity = new FilmEntity()
        {
            Name = request.FilmName,
            Rating = request.Rating,
        };
        
        var addedEntity = await _baseRepository.Add(filmEntity);
        var addedModel = _mapper.Map<FilmModel>(addedEntity);

        return addedModel;
    }
}