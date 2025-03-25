using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecretosParaContar.Data.Models;

namespace SecretosParaContar.Data.Repositories
{
    public class DonacionRepository : IDonacionRepository
    {
        private readonly SecretoContext _context;

        public DonacionRepository(SecretoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Donacion>> ObtenerDonaciones()
        {
            return await _context.Donaciones.ToListAsync();
        }

        public async Task<Donacion> ObtenerDonacionPorId(int id)
        {
            return await _context.Donaciones.FindAsync(id);
        }

        public async Task AgregarDonacion(Donacion donacion)
        {
            _context.Donaciones.Add(donacion);
            await _context.SaveChangesAsync();
        }
    }
}
