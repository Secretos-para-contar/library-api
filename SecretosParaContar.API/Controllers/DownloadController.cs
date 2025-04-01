using Microsoft.AspNetCore.Mvc;
using SecretosParaContar.Business.Services;

namespace SecretosParaContar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly DownloadService _downloadService;

        public DownloadController(DownloadService downloadService)
        {
            _downloadService = downloadService;
        }

        [HttpPost("click")]
        public IActionResult RegisterClick([FromBody] string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return BadRequest("User ID is required");

            _downloadService.RegisterClick(userId);
            return Ok(new { message = "Click registered successfully" });
        }

        [HttpGet("count/{userId}")]
        public IActionResult GetClickCount(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return BadRequest("User ID is required");

            int count = _downloadService.GetClickCount(userId);
            return Ok(new { userId, clickCount = count });
        }
    }
}
