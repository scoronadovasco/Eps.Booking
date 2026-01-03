using Eps.Booking.Api;
using Eps.Booking.Application;
using Eps.Booking.Application.Interfaces;
using Eps.Booking.Common;
using Eps.Booking.External;
using Eps.Booking.Persistence;
using Eps.Booking.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddWebAPi()
        .AddCommon()
        .AddApplication()
        .AddExternal(builder.Configuration)
        .AddPersistence(builder.Configuration);
var app = builder.Build();

app.Run();

