using Microsoft.AspNetCore.Mvc;
using SecretosParaContar.Business.interfaces;
using SecretosParaContar.Data.Models;

namespace SecretosParaContar.Controller;

[ApiController]
[Route("api/[controller]")]

public class AutorController : ControllerBase

{
    private readonly IAutorService _autorService;

    public AutorController (IAutorService autorService)
    {
        _autorService = autorService;
    }

    [HttpPost]
    [Route("AddAutor")]
        public async Task<IActionResult> AddAutor([FromBody] Autor autor)
    {
    var result = await _autorService.AddAutor(autor);
    return Ok(result);
    }


    [HttpGet]
    [Route("GetById")]

    public async Task<IActionResult> GetById (int id)
    {
        var autor = await _autorService.FindById(id);
        return  Ok(autor);
    }
}