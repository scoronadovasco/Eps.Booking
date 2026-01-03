using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Eps.Booking.Application;


public static class DependencyInjectionService
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var mapper = new MapperConfiguration(config =>
        {
            config.AddProfile(new MapperProfile());
        });

        services.AddSingleton(mapper.CreateMapper());
        return services;
    }
}