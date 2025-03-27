using SecretosParaContar.Data.Models;

namespace SecretosParaContar.Business.interfaces;

public interface IAutorService

{
    public Task<Autor> FindById(int id);

    public Task<Autor> AddAutor(Autor artist);
}