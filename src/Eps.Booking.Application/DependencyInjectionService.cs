using AutoMapper;
using Eps.Booking.Application.DataBase.Doctor.Commands;
using Eps.Booking.Application.DataBase.Doctor.Querys;
using Eps.Booking.Application.DataBase.Patient.Commands;
using Eps.Booking.Application.DataBase.Patient.Queries;
using Eps.Booking.Application.DataBase.Speciality.Commands;
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
        services.AddTransient<ICreateSpecialityCommand, CreateSpecialityCommand>();
        services.AddTransient<IUpdateSpecialityCommand, UpdateSpecialityCommand>();
        services.AddTransient<ICreateDoctorCommand, CreateDoctorCommand>();
        services.AddTransient<IUpdateDoctorCommand, UpdateDoctorCommand>();
        services.AddTransient<IDeleteDoctorCommand, DeleteDoctorCommand>();
        services.AddTransient<IGetAllDoctorsQuery, GetAllDoctorsQuery>();
        services.AddTransient<IGetDoctorByIdQuery, GetDoctorByIdQuery>();
        services.AddTransient<ICreatePatientCommand, CreatePatientCommand>();
        services.AddTransient<IUpdatePatientCommand, UpdatePatientCommand>();
        services.AddTransient<IGetAllPatientQuery, GetAllPatientQuery>();

        return services;
    }
}