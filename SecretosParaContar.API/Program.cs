using Microsoft.EntityFrameworkCore;
using SecretosParaContar.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddScoped<IDonacionRepository, DonacionRepository>();
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

{

builder.Services.AddDbContext<SecretoContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("SecretosDataBase"))
);
}
// TODO: Hacer inyección de dependencias y patron singleton

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();
app.MapControllers();

app.Run();