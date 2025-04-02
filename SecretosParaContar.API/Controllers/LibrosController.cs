using Microsoft.AspNetCore.Mvc;
using SecretosParaContar.Business.interfaces;
using SecretosParaContar.Business.Service;
using SecretosParaContar.Data.Models;
using SecretosParaContar.Data;
using System.Net;

namespace SecretosParaContar.API.Controller

// TODO: Despues de hacer la inyección de dependencias y patron singleton descomentar las siguientes lineas
// Y generar la inyección de dependencias en el constructor


{
    [Route("Api/[controller]")]
    [ApiController]

    public class LibrosController : ControllerBase

    {
        private readonly ILibroService _libroService;

        public LibrosController(ILibroService libroService)
        {
            _libroService = libroService;
        }

        [HttpGet]
        [Route("GetLibros")]
        
        public async Task<IActionResult> GetLibros()
        {
            var libros = await _libroService.GetList();
            return Ok(libros);
    
        }
        
        [HttpPost]
        [Route("AddLibros")]
        
        public async Task<IActionResult> AddLibros(Libros libro)
        {
             var result = await _libroService.AddLibro(libro);
            return Ok(result);
         }

         [HttpGet("GetLibrosName")]
        
        public async Task<IActionResult> GetLibrosName(string name)
         {
            var result = await _libroService.FindByName(name);

             return result.TotalElements > 0 ?
             Ok(result) :
             NotFound(result);
         }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
         {
            var result = await _libroService.GetById(id);
    
            return result.TotalElements > 0 ? 
            Ok(result) : 
            NotFound(result);
        }
    }
};
