

using System.Reflection;
using AutoMapper;
using SignalR.Core.Repositories;
using SignalR.Core.Services;
using SignalRApi.Mapper;
using SignalRRepository.Concrete;
using SignalRRepository.EntityFramework;
using SignalRService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<SignalRContext>();

builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IAboutRepository, AboutRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
