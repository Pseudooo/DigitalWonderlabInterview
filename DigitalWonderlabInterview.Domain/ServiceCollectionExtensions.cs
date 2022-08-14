using DigitalWonderlabInterview.Domain.Interface;
using DigitalWonderlabInterview.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalWonderlabInterview.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDomainDependencies(this IServiceCollection sc)
    {
        sc.AddDbContext<DataContext>(opts => {
            opts.UseNpgsql("User ID=wonderlab;Password=averystrongpassword;Host=localhost;Port=5432;Database=wonderlab;Pooling=true;Connection Lifetime=0;");
        });
        
        sc.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        return sc;
    }
}