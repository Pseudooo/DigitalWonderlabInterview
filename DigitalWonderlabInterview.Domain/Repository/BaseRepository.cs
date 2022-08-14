using DigitalWonderlabInterview.Domain.Entities;
using DigitalWonderlabInterview.Domain.Interface;

namespace DigitalWonderlabInterview.Domain.Repository;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    internal DataContext Context { get; set; }

    public BaseRepository(DataContext context)
    {
        Context = context;
    }

    public async Task<TEntity> Add(TEntity entity)
    {
        await Context.AddAsync(entity);
        await Context.SaveChangesAsync();

        return entity;
    }
}