using DigitalWonderlabInterview.Domain.Entities;

namespace DigitalWonderlabInterview.Domain.Interface;

public interface IFilmRepository : IBaseRepository<FilmEntity>
{
    Task<IEnumerable<FilmEntity>> SearchForFilm(string searchTerm);
}