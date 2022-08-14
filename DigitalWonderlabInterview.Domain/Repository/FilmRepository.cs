using DigitalWonderlabInterview.Domain.Entities;
using DigitalWonderlabInterview.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace DigitalWonderlabInterview.Domain.Repository;

public class FilmRepository : BaseRepository<FilmEntity>, IFilmRepository
{
    public FilmRepository(DataContext context) : base(context)
        { }

    public async Task<IEnumerable<FilmEntity>> SearchForFilm(string searchTerm)
    {
        var result = await Context.Films.Where(film => EF.Functions.Like(film.Name, $"%{searchTerm}%"))
                                        .ToListAsync();

        return result;
    }
}
