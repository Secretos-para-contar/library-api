using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using SecretosParaContar.Data;
using SecretosParaContar.Data.Models;

namespace SecretosParaContar.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly SecretoContext _context;
    private IRepository<int, Libros> _libroRepository;
    private IRepository<int, Autor> _autorRepository;
    private bool _disposed = false;

    public UnitOfWork(SecretoContext context)
    {
        _context = context;
    }

    public IRepository<int, Autor> AutorRepository
    {
        get
        {
            _autorRepository ??= new Repository <int, Autor>(_context);
            return _autorRepository;
        }
    }

    public IRepository<int, Libros> LibroRepository
    {
        get
        {
            _libroRepository ??= new Repository<int, Libros>(_context);
            return _libroRepository;
        }
    }

    public async Task SaveAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();
        }
    }

    #region IDisposable
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.DisposeAsync();
            }
        }
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
    }
    #endregion
}
