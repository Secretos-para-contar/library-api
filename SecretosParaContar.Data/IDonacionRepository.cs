using System.Collections.Generic;
using System.Threading.Tasks;
using SecretosParaContar.Data.Models;

namespace SecretosParaContar.Data.Repositories
{
    public interface IDonacionRepository
    {
        Task<IEnumerable<Donacion>> ObtenerDonaciones();
        Task<Donacion> ObtenerDonacionPorId(int id);
        Task AgregarDonacion(Donacion donacion);
    }
}
