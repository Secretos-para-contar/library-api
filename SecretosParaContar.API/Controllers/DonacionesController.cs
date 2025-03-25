using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using SecretosParaContar.Data.Models;
using SecretosParaContar.Data.Repositories;

namespace SecretosParaContar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonacionesController : ControllerBase
    {
        private readonly IDonacionRepository _donacionRepository;

        public DonacionesController(IDonacionRepository donacionRepository)
        {
            _donacionRepository = donacionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donacion>>> GetDonaciones()
        {
            return Ok(await _donacionRepository.ObtenerDonaciones());
        }

        [HttpPost]
        public async Task<ActionResult> PostDonacion([FromBody] Donacion donacion)
        {
            await _donacionRepository.AgregarDonacion(donacion);
            return CreatedAtAction(nameof(GetDonaciones), new { id = donacion.Id }, donacion);
        }
    }
}
