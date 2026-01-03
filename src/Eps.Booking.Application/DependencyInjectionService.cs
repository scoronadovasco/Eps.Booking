using Microsoft.Extensions.DependencyInjection;

namespace Eps.Booking.Application;


public static class DependencyInjectionService
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}