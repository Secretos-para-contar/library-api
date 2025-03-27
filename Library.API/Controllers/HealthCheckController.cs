using Library.API.Contracts;
using Library.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController(Supabase.Client supabase) : Controller
{
   private readonly Supabase.Client _supabase = supabase;

   [HttpGet("status/{id}")]
   public async Task<IActionResult> GetHealthCheckStatus(long id)
   {
      var response = await _supabase.From<Health>().Where(n => n.Id == id).Get();

      var healthCheck = response.Models.FirstOrDefault();
      
      if (healthCheck == null)
      {
         return NotFound();
      }
      
      var healthResponse = new HealthResponse
      {
         Id = healthCheck.Id,
         Author = healthCheck.Author,
         CreateAt = healthCheck.CreateAt
      };

      return Ok(healthResponse);
   }
   
}