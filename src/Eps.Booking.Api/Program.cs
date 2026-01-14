using Eps.Booking.Api;
using Eps.Booking.Application;
using Eps.Booking.Common;
using Eps.Booking.External;
using Eps.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddWebAPi()
        .AddCommon()
        .AddApplication()
        .AddExternal(builder.Configuration)
        .AddPersistence(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

