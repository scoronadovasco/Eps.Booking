using Eps.Booking.Application.Interfaces;
using Eps.Booking.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();


var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

builder.Services.AddDbContext<DataBaseService>(options => options.UseSqlServer(builder.Configuration["SqlConnectionStrings"]));

builder.Services.AddScoped<IDataBaseService, DataBaseService>();

var app = builder.Build();

app.Run();

