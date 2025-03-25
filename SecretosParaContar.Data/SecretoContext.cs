using Microsoft.EntityFrameworkCore;
using SecretosParaContar.Data.Models;

public class SecretoContext : DbContext

{
    public SecretoContext (DbContextOptions<SecretoContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


    }

    public DbSet<Libros> libros {get;set;}

    public DbSet<Donacion> Donaciones {get;set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        if(builder == null)
        {
            return;
        }

        builder.Entity<Libros>().ToTable("Libro").HasKey(k => k.Id);
        builder.Entity<Autor>().ToTable("Autor").HasKey(k => k.Id);
        base.OnModelCreating(builder);
    }
}