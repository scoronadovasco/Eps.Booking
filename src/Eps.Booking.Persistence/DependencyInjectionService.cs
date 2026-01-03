using Eps.Booking.Application.DataBase;
using Eps.Booking.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eps.Booking.Persistence;


public static class DependencyInjectionService
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<DataBaseService>(options => options.UseSqlServer(configuration["SqlConnectionStrings"]));

        services.AddScoped<IDataBaseService, DataBaseService>();
        return services;
    }
}