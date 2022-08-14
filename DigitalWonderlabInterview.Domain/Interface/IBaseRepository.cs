namespace DigitalWonderlabInterview.Domain.Interface;

public interface IBaseRepository<TEntity>
{
    Task<TEntity> Add(TEntity entity);
}
