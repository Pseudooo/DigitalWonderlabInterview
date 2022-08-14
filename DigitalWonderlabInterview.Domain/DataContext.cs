using DigitalWonderlabInterview.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalWonderlabInterview.Domain;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

    public DbSet<FilmEntity> Films { get; set; } = null!;
}