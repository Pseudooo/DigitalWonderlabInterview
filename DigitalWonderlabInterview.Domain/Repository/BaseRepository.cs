using DigitalWonderlabInterview.Domain.Entities;
using DigitalWonderlabInterview.Domain.Interface;

namespace DigitalWonderlabInterview.Domain.Repository;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    private readonly DataContext _context;

    public BaseRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<TEntity> Add(TEntity entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }
}