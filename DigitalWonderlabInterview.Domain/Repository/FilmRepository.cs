using DigitalWonderlabInterview.Domain.Entities;
using DigitalWonderlabInterview.Domain.Interface;

namespace DigitalWonderlabInterview.Domain.Repository;

public class FilmRepository : BaseRepository<FilmEntity>, IFilmRepository
{
    public FilmRepository(DataContext context) : base(context)
        { }

    public Task<IEnumerable<FilmEntity>> SearchForFilm(string searchTerm)
    {
        throw new NotImplementedException();
    }
}
