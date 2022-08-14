using DigitalWonderlabInterview.ClientModel;
using DigitalWonderlabInterview.Service.Commands;
using MediatR;

namespace DigitalWonderlabInterview.Service.Handlers;

public class AddFilmHandler : IRequestHandler<AddFilmCommand, FilmModel>
{
    public Task<FilmModel> Handle(AddFilmCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}