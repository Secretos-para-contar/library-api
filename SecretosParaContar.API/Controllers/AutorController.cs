using Microsoft.AspNetCore.Mvc;
using SecretosParaContar.Business.interfaces;

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

    [HttpGet]
    [Route("GetById")]

    public async Task<IActionResult> GetById (int id)
    {
        var autor = await _autorService.FindById(id);
        return  Ok(autor);
    }
}