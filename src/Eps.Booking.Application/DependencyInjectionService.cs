using AutoMapper;
using Eps.Booking.Application.DataBase.User;
using Eps.Booking.Application.DataBase.User.Commands;
using Eps.Booking.Application.DataBase.User.Querys;
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
        services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
        services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
        services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
        services.AddTransient<IGetAllUsersQuery, GetAllUsersQuery>();
        services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
        return services;
    }
}