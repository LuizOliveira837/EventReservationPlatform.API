using EventReservationPlatform.API;
using EventReservationPlatform.API.Filters;
using EventReservationPlatform.Application.Services;
using EventReservationPlatform.Core.Entities;
using EventReservationPlatform.Core.Interface.Repositories;
using EventReservationPlatform.Core.Interface.Services;
using EventReservationPlatform.Core.Validators;
using EventReservationPlatform.Persistence.Database;
using EventReservationPlatform.Persistence.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc(options =>
{
    options.Filters.Add(typeof(ExceptionFilter));
});


var connectionString = builder.Configuration.GetConnectionString("EventReservationDB");
builder.Services.AddDbContext<EventReservationDbContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddValidatorsFromAssemblyContaining<RoomValidator>();
builder.Services.RegisterMapsterConfiguration();


builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
