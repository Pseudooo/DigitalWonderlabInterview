using DigitalWonderlabInterview.Domain.Interface;
using DigitalWonderlabInterview.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalWonderlabInterview.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDomainDependencies(this IServiceCollection sc)
    {
        sc.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        return sc;
    }
}