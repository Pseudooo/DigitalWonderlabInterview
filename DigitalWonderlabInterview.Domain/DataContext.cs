using DigitalWonderlabInterview.Domain.Entities.FilmEntity;
using Microsoft.EntityFrameworkCore;

namespace DigitalWonderlabInterview.Domain;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
        { }

    public DbSet<FilmEntity> Films { get; set; } = null!;
}