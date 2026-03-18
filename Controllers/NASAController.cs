using Microsoft.AspNetCore.Mvc;
using NASA_API.Services;

namespace NASA_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NASAController : ControllerBase
    {
        private readonly ILogger<NASAController> _logger;
        private readonly NasaService _nasaService;

        public NASAController(ILogger<NASAController> logger, NasaService nasaService)
        {
            _logger = logger;
            _nasaService = nasaService;
        }

        [HttpGet("exoplanets")]
        public async Task<IActionResult> GetExoplanets()
        {
            var exoplanets = await _nasaService.GetExoplanets();

            return Ok(exoplanets);
        }
    }
}
