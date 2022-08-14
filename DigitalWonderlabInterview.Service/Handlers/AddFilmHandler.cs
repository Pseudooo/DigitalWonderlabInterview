using DigitalWonderlabInterview.ClientModel;
using DigitalWonderlabInterview.Domain.Entities.FilmEntity;
using DigitalWonderlabInterview.Domain.Interface;
using DigitalWonderlabInterview.Service.Commands;
using MediatR;

namespace DigitalWonderlabInterview.Service.Handlers;

public class AddFilmHandler : IRequestHandler<AddFilmCommand, FilmModel>
{
    private readonly IBaseRepository<FilmEntity> _baseRepository;

    public AddFilmHandler(IBaseRepository<FilmEntity> baseRepository)
    {
        _baseRepository = baseRepository;
    }

    public async Task<FilmModel> Handle(AddFilmCommand request, CancellationToken cancellationToken)
    {
        var filmEntity = new FilmEntity()
        {
            Name = request.FilmName,
        };
        
        var addedEntity = await _baseRepository.Add(filmEntity);

        return new FilmModel()
        {
            Id = addedEntity.Id,
            Name = addedEntity.Name,
        };
    }
}