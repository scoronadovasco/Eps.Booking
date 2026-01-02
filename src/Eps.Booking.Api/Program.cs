using Eps.Booking.Application.Interfaces;
using Eps.Booking.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();
builder.Services.AddDbContext<DataBaseService>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings"]));

builder.Services.AddScoped<IDataBaseService, DataBaseService>();

var app = builder.Build();

app.Run();

