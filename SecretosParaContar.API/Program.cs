using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SecretosParaContar.Business.interfaces;
using SecretosParaContar.Business.Service;
using SecretosParaContar.Data;
using SecretosParaContar.Data.Repositories;
using SecretosParaContar.Business.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddScoped<IAutorService, AutorService>();
builder.Services.AddScoped<IDonacionRepository, DonacionRepository>();
builder.Services.AddSingleton<DownloadService>();



{

builder.Services.AddDbContext<SecretoContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("SecretosDataBase"))
);
}
// TODO: Hacer inyección de dependencias y patron singleton

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.MapControllers();

app.Run();