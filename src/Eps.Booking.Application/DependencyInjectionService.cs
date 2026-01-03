using AutoMapper;
using Eps.Booking.Application.DataBase.User.Commands;
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
        services.AddTransient<ICreateUserCommand, CreateUserCommand>();
        return services;
    }
}