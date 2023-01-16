using Backend.UrlShortener.Application;

namespace Backend.UrlShortener.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUrlShortener(this IServiceCollection services) => services
        .AddScoped<SaveShortUrl>();
}