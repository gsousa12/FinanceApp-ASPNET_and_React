using Api.Extensions;
using Application.Common;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Adicione esta linha para suportar controllers

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AppConfig -> ConnectionStrings
builder.Services.Configure<AppConfig>(builder.Configuration.GetSection("ConnectionStrings"));

// Configurações do Postgres
builder.Services.AddDbContext<FinanceDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

// Configurações JWT
builder.Services.AddJwtAuthentication(builder.Configuration);

builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Adicione estas duas linhas para habilitar roteamento e auth
app.UseAuthentication(); // Adicione ANTES do UseAuthorization
app.UseAuthorization();

app.MapControllers(); // Mapeia todos os controllers

app.Run();
