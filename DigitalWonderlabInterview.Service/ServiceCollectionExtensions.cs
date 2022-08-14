using System.Reflection;
using DigitalWonderlabInterview.ClientModel;
using DigitalWonderlabInterview.Domain.Entities;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalWonderlabInterview.Service;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection sc)
    {
        sc.AddMediatR(Assembly.GetExecutingAssembly());

        var mappingConfig = new TypeAdapterConfig();
        mappingConfig.NewConfig<FilmEntity, FilmModel>();

        sc.AddSingleton(mappingConfig);

        sc.AddScoped<IMapper, ServiceMapper>();

        return sc;
    }
}