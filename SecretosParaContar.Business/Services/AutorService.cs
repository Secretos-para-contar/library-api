using SecretosParaContar.Business.interfaces;
using SecretosParaContar.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace SecretosParaContar.Business.Service;

public class AutorService : IAutorService
{
    private readonly SecretoContext _context;

    public AutorService(SecretoContext context)
    {
        _context = context;
    }

    public async Task<Autor> AddAutor(Autor autor)
    {
        _context.Autor.Add(autor);
        await _context.SaveChangesAsync(); // Guarda en la BD
        return autor;
    }

   public async Task<Autor> FindById(int id) 
    {
    return await _context.Autor.FindAsync(id) ?? new Autor();
    }


    public async Task<List<Autor>> GetAllAutores()
    {
        return await _context.Autor.ToListAsync();
    }
}
